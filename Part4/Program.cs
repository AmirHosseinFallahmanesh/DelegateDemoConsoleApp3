using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        public delegate void Calc(int a, int b);
        static void Main(string[] args)
        {
            Calc calc = new Calc(delegate (int a, int b){
             Console.WriteLine(a+b); 
            });

            Calc calc1 = new Calc(delegate (int a, int b) {
                Console.WriteLine(a/b);
            });
        }
    }
}
