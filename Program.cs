// See https://aka.ms/new-console-template for more information
using Calculator.Logic;

try
{
    startpoint:
    var operation = string.Empty;

    Console.WriteLine("Select Operation \n Type 1 for Addition \n Type 2 for Subtraction \n Type 3 for Division \n Type 4 for multiplication");

    operation = Console.ReadLine();

    while (!IsInputValidated(operation?? ""))
    {
        Console.WriteLine("Select Operation \n Type 1 for Addition \n Type 2 for Subtraction \n Type 3 for Division \n Type 4 for multiplication");

        operation = Console.ReadLine();
    }


    static bool IsInputValidated(string operation)
    {
        if (string.IsNullOrEmpty(operation) || (!operation.Equals("1")& !operation.Equals("2") & !operation.Equals("3") & !operation.Equals("4")))
        {
            Console.WriteLine("Invalid Input. Try again");
            return false;
        }

        return true;
    }

    Console.WriteLine("Supply the first number");

    var a = decimal.TryParse(Console.ReadLine(), out decimal result) ? result : 0;

    Console.WriteLine("Supply the Second number");

    var b = decimal.TryParse(Console.ReadLine(), out decimal result2) ? result2 : 0;



    var logic = new LogicService();


    switch (operation)
    {
        case "1":
            Console.WriteLine("You picked Addition");
            Console.WriteLine("\nSolved! {0}", logic.Add(a, b));
            break;
        case "2":
            Console.WriteLine("You picked Subtraction");
            Console.WriteLine("\nSolved! {0}", logic.Subtract(a, b));
            break;
        case "3":
            Console.WriteLine("You picked Division");
            Console.WriteLine("\nSolved! {0}", logic.Divide(a, b));
            break;
        case "4":
            Console.WriteLine("You picked Multiplication");
            Console.WriteLine("\nSolved! {0}", logic.Multiply(a, b));
            break;
        default:
            throw new ArgumentException("operation not found");
    }

    goto startpoint;
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    throw;
}