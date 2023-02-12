using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    internal class LogicService
    {
        public decimal Add(decimal a, decimal b) => a + b;
        public decimal Subtract(decimal a, decimal b) => a - b;
        public decimal Divide(decimal a, decimal b) => a / b;
        public decimal Multiply(decimal a, decimal b) => a * b;
    }
}
