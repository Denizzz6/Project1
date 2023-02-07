using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = (30);

            //int number1 = 20;
            //int number2 = 50;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            //Console.ReadLine();


            //int number1 = 20;
            //int number2 = 50;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(multiply(5, 7));
            Console.WriteLine(multiply(5, 7, 8));
            Console.WriteLine(Add4(1, 8, 7, 9, 5));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("added");
        }
        static int Add2(int number1, int number2 = 20)
        {
            var result = number1 + number2;
            return result;
        }

        //static int Add3(ref int number1, int number2)
        //{

        //         number1 = 30;
        //         return number1 + number2;

        //}

        static int Add3(out int number1, int number2)
        {

            number1 = 30;
            return number1 + number2;

        }

        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number , params int [] numbers)
            {
            return numbers.Sum();
            }   
    }
 }
