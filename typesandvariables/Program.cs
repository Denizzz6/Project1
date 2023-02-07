using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesandvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("f");
            int number1 = 20;
            long number2 = 50;
            short number3 = 8;
            byte number4 = 72;
            double number5 = 10.8;
            decimal number6 = 10.4m;
            bool condition = false;
            char character = 'a';
            var number7 = 10;
                number7 = 'a';
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Character is:{0}", (int)character);
            Console.WriteLine((int)days.wednesday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();

        }
    }
}

enum days


{
    monday,tuesday,wednesday,thursday,friday,saturday,sunday

}