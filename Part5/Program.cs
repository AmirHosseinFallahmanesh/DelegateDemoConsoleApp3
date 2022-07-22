using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    //delegate => void  => action
    //delegate =>return =>function
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> ac = (number) => { Console.WriteLine(number); };

            Action<int, int> ac1 = (number1, number2) =>  Console.WriteLine(number1+number2);

            Action<int, string, int> ac2 = (id, name, age) => Console.WriteLine($"id = {id}  {name}  {age}");
            // ac2.Invoke(1, "amir", 18);

            Action<string> ac3 = (name) => Console.WriteLine("Hello " + name);
            operation((name) => Console.WriteLine("Hello " + name), "amir");

            Console.ReadLine();

        }

        static void operation(Action<string> ac, string name)
        {
            ac.Invoke(name);

        }
    }
}
