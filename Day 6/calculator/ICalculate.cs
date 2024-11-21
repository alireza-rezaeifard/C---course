using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal interface ICalculate
    {
        int plus(int FirstNumber, int SecondNumber);

        int minus(int FirstNumber, int SecondNumber);
        int mutiple(int FirstNumber, int SecondNumber);
        int divide(int FirstNumber, int SecondNumber);

    }
}
