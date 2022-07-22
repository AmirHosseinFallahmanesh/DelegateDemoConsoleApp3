using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> fn = () => { return "welcome"; };
            Func<string, string> fn1 = (name) => { return "hello " + name; };
            Func<int, int, string> fn2 = (number1, number2) => { return (number1 + number2).ToString()};

            Where(a => a.StartsWith("a"));

            List<string> data = new List<string>();
            data.Where(a => a.StartsWith("a"));
        }
        static void Where(Func<string,bool> perdicate)
        {
            perdicate.Invoke("a");
        }

    }
}
