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
        static void Main(string[] args)
        {
        }
    }
}
