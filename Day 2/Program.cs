using System;

namespace Day2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Greetings
            //Console.WriteLine("What is your name?");
            // string userName = Console.ReadLine();
            // Console.WriteLine("Hello "+ userName +"! Nice to meet you.");
            // double num1;
            // double num2;
            // Console.WriteLine("Input a number:");
            // num1 =Convert.ToDouble( Console.ReadLine());
            // Console.WriteLine("Input a another number:");
            // num2 =Convert.ToDouble( Console.ReadLine());
            
            // double result = num1+num2;
            // Console.WriteLine("The summation is " +result);
            // challenge
            // double num1;
            // double num2;
            // double num3;
            // Console.WriteLine("Input a number:");
            // num1 =Convert.ToDouble( Console.ReadLine());
            // Console.WriteLine("Input a another number:");
            // num2 =Convert.ToDouble( Console.ReadLine());
            // Console.WriteLine("Input a another number:");
            // num3 =Convert.ToDouble( Console.ReadLine());
            // double result = (num1+num2+num3) / 3;
            // Console.WriteLine("The average of the three numbers are: "+ result);
            // If condition
            // Console.WriteLine("Welcome! The tickets cost 5$");
            // int cash = Convert.ToInt32(Console.ReadLine());
            // if (cash < 5)
            // {
            //     Console.WriteLine("You can go in");
            // }
            // else if(cash ==5)
            // {
            //     Console.WriteLine("Here you go!");
            // }
            // else
            // {
            //     int change = cash - 5;
            //     Console.WriteLine("Here is your ticket and" + change + " dollas in change");
            // }
            // Challenge

            Console.WriteLine("(4+2+4+6) / 2");
            int problem01 = Convert.ToInt32(Console.ReadLine());
            
            if (problem01 == 8)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine("(4+2+4+0) / 2");
            
            int problem02 = Convert.ToInt32(Console.ReadLine());
            
            if (problem02 == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
                
            }
            Console.WriteLine("(6+12+3+9) / 3");
            int problem03 = Convert.ToInt32(Console.ReadLine());
            
            
            
            if (problem03 == 10)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            

            


            
            // wait before closing
            Console.ReadKey();
        }
    }
}