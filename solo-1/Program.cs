// See https://aka.ms/new-console-template for more information
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace Solo_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //lesson 3.1

            Console.WriteLine("C# is cool");


            // lesson 4.1

            int x = 3;
            int y = 4;

            Console.WriteLine("x={0}; y={1}", x,y);

            //lesson 5.1

            string name;
            Console.WriteLine("what's your name?");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("how old are you?");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("hi there, {0}! you are {1} years old.", name, age);

        }
    }
}
