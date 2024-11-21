using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculate : ICalculate
    {
        public int divide(int FirstNumber, int SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }

        public int minus(int FirstNumber, int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        public int mutiple(int FirstNumber, int SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        public int plus(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
    }
}
