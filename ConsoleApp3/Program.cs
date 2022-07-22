using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        delegate void Md();
        delegate void MD1(string name);
        delegate string MD2(string name, string surname);
        static void Main(string[] args)
        {
            //Md md = print;
            //md();
            //md.Invoke();

            //MD1 md1 = welcome;
            //md1.Invoke("amir");

            MD2 md2 = welcome1;
            Console.WriteLine(md2.Invoke("amir","amiri"));



            Console.ReadKey();

        }

        static void print()
        {
            Console.WriteLine("hello");
        }

        static void welcome(string name)
        {
            Console.WriteLine("welcome "+name);        
         }

        static string welcome1(string name,string surname)
        {
            return "welcome " + name + " " + surname;
        }
    }
}
