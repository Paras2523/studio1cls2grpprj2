﻿using System;
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
         public static void joanna ()
        {
            int balance, posNeg;
            Random rand = new Random();
            Console.WriteLine("Generating your bank balance");
            Console.WriteLine("Please wait.  ");
            Thread.Sleep(200);

            balance = rand.Next(1001);
            posNeg = rand.Next(2);

            if (posNeg == 0)
            {
                balance = balance * -1;
                Console.WriteLine("Can you hear that sound? It's your card being declined");
                Console.Beep();
                Console.Beep((int)523.2, 300);
                Console.Beep((int)523.2, 300);
                Console.Beep((int)523.2, 300);
            }
            else
            {
                Console.WriteLine("Positive balance");
            }
            Console.WriteLine($"Your balance is {balance}");
            Thread.Sleep(5000);
            Console.ReadLine();
        }

        public static void josh2()
        {
            int t1Score, t2Score;
            Random rand = new Random();
            t1Score = rand.Next(10);
            t2Score = rand.Next(10);

            if (t2Score > t1Score)

            {

                Console.WriteLine("Well done! Team 2 Won");
                Console.WriteLine($"Team 1's score was {t1Score} while Team 2's score was {t2Score}");

            }

            else if (t2Score < t1Score)

            {

                Console.WriteLine("Unfortunately Team 2 has Lost :( and been defeated by team 1");
                Console.WriteLine($"Team 1's score was {t1Score} while Team 2's score was {t2Score}");
            }

            else

            {

                Console.WriteLine("It was so close Team 1 and Team 2 have drawn");
                Console.WriteLine($"Team 1's score was {t1Score} while Team 2's score was {t2Score}");

            }


            Console.ReadLine();
        }

        static void Main(string[] args)
        {
        

        }

    }
}
