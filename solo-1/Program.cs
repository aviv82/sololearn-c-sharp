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

            //lesson 9.1

            Console.WriteLine("number one is?");
            int one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number two is?");
            int two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number three is?");
            int three = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number four is?");
            int four = Convert.ToInt32(Console.ReadLine()); 
             
            Console.WriteLine("number five is?");
            int five = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your numbers are: {0}, {1}, {2}, {3} & {4}.", one, two, three, four, five);
            Console.WriteLine("some randome arithmatics:");
            Console.WriteLine((one-two * (three/four))%5);

            //lesson 10.1

            int a = 2;
            int b = 4;

            int c = a--;
            int d = ++b;

            Console.WriteLine("number a = {0}, number b = {1}",  a,b);
            Console.WriteLine("number c = {0}, number d = {1}", c, d);


        }
    }
}
