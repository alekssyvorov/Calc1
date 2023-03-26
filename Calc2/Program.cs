using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result = {Calc(1.5f, 2.3f, "-", false)}");
            Console.ReadLine();
        }

        public static float Calc(float firstOperant, float secndOperant, string operation, bool isRevers = false)
        {
            float result=0;
            if (!isRevers)
            {
                if (operation == "+")
                    result = firstOperant + secndOperant;
                else if (operation == "-")
                    result = firstOperant - secndOperant;
                else if (operation == "*")
                    result = firstOperant * secndOperant;
                else if (operation == "/")
                    result = firstOperant / secndOperant;
            }
            else
            {
                if (operation == "+")
                    result = secndOperant + firstOperant;
                else if (operation == "-")
                    result = secndOperant - firstOperant;
                else if (operation == "*")
                    result = secndOperant * firstOperant;
                else if (operation == "/")
                    result = secndOperant / firstOperant;
            }
            return result;
        }
    }
}
