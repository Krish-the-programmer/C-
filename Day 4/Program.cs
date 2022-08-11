using System;
using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are there in the class: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the students name please: ");
            string[] students = new string[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("Alphabeticalley");
            Array.Sort(students);
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(students[i]);
            }
            // Waites before closing
            Console.ReadKey();

        }
    }
}
