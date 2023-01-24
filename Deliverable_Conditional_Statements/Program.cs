/*
 * Author: Jessica C
 * Date: 1/23/2023
 * Description: C# Console Application for calculating letter grades.
 * */

using System;
using System.Diagnostics.Metrics;

namespace Deliverable_Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try 
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 50 && grade < 60)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
            }

            catch
            {
                Console.WriteLine("Enter a numeric value ");
            }
            
        }
    }
}