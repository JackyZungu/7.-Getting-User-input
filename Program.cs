using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.Write("How old are you");
            string age = Console.ReadLine();
            Console.WriteLine("you are " + age);
            Console.ReadLine();
        }
    }
}
