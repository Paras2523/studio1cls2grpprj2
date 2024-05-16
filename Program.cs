using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void paras()
        {
            int num, pow;
            Console.WriteLine("enter the number.");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ammount of power.");
            pow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your answer is {Math.Pow(num, pow)}");
        }

        public static void josh()
        {
            int num1, num2, num3;
            string temp;

            Console.Write("Please enter your first number: ");
            temp = Console.ReadLine();
            num1 = Convert.ToInt32(temp);
            Console.Write("Please enter your second number: ");
            temp = Console.ReadLine();
            num2 = Convert.ToInt32(temp);
            Console.Write("Please enter your third number: ");
            temp = Console.ReadLine();
            num3 = Convert.ToInt32(temp);

            if ((num1 <= num2) && (num2 <= num3))

            {
                Console.WriteLine("Your numbers are in ascending numerical order");
            }
            else

            {

                Console.WriteLine("Your numbers are not in an ascending numerical order");

            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
        

        }

    }
}
