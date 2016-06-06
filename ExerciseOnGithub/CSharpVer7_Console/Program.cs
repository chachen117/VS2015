using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpVer7_Console.Ch8_Delegate;

namespace CSharpVer7_Console
{
    delegate double DoubleOp(double x);

    class Program
    {
        static void Main(string[] args)
        {
            DoubleOp[] operations = { MathOperations.MultiplyByTwo, MathOperations.Square };

            for (int i = 0; i< operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);

            }
            Console.ReadLine();
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine(
                "Value is {0}, result of operation is {1}", value, result);
        }
    }
}
