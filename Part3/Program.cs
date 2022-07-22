using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {

        public delegate void My_delegate();
        public delegate void my_del_parameter(string name);
        public delegate string my_string(string name);
        public delegate string my_strings(string name, int id);
        static void Main(string[] args)
        {
            My_delegate md = new My_delegate(delegate ()
            {
                Console.WriteLine("hi"); 
            });
            My_delegate md5 = new My_delegate(() => {
                Console.WriteLine("hi");
            });

            My_delegate md9 = () => {
                Console.WriteLine("hi");
            };


            // md();
            my_del_parameter md2 = new my_del_parameter(delegate (string name)
            {
                Console.WriteLine("Hello "+name);
            });

            my_del_parameter md6 = new my_del_parameter( (name)=>
            {
                Console.WriteLine("Hello " + name);
            });


            my_del_parameter md10 =(name) =>
            {
                Console.WriteLine("Hello " + name);
            };

            //md2.Invoke("amir");

            my_string md3 = new my_string(delegate (string name) { 
                return "Hi "+name;
            });
            my_string md7 = new my_string((name) => {
                return "Hi " + name; 
            });

            my_string md11 = (name) => {
                return "Hi " + name;
            };

            //Console.WriteLine(md3.Invoke("amir"));

            my_strings md4 = new my_strings(delegate (string name, int id) { 
             return id.ToString(); }
            );
            my_strings md8 = new my_strings((name, id) => {
                return id.ToString(); 
            });

            my_strings md12 = (name, id) => { return id.ToString(); };

            Console.ReadKey();
        }
    }
}
