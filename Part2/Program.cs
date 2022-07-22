using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        delegate void calculate(int number1, int number2);
        static void Main(string[] args)
        {
            calculate calculate = sum;
            calculate += minus;
            calculate += div;
            calculate += mul;
            calculate.Invoke(8, 4);
            Console.ReadKey();
        }

        static void sum(int number1, int number2) => Console.WriteLine(number1 + number2);
        static void minus(int number1, int number2) => Console.WriteLine(number1 - number2);

        static void mul(int number1, int number2) => Console.WriteLine(number1 * number2);

        static void div(int number1, int number2) => Console.WriteLine(number1 / number2);
    }
}
