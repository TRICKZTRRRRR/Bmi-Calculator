using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the title of the console window
            Console.Title = "BMI Calculator";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Start an infinite loop for continuous calculations
            while (true)
            {
                // Clear the console screen
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                // Prompt for weight input
                Console.WriteLine("Weight");
                double cmWeight = double.Parse(Console.ReadLine());

                // Prompt for height input
                Console.WriteLine("\r\nHeight");
                double cmHeight = double.Parse(Console.ReadLine());

                // Calculate BMI using the formula: BMI = (weight / height^2) * 10000
                double cmCalculation = (cmWeight / Math.Pow((cmHeight), 2)) * 10000;

                // Display the calculated BMI
                Console.WriteLine("\r\nBMI = " + cmCalculation.ToString("0.##"));

                // Determine BMI category and display appropriate message with color
                if (cmCalculation < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You are underweight");
                }
                else if (cmCalculation >= 18.5 && cmCalculation < 24)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are Normal weight");
                }
                else if (cmCalculation >= 24 && cmCalculation < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You are Obese");
                }
                else if (cmCalculation >= 30 && cmCalculation < 35)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You are Obese First Degree");
                }
                else if (cmCalculation >= 35 && cmCalculation < 40)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are Obese Second Degree");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You are Obese Third Degree");
                }

                // Wait for user to press Enter before restarting the loop
                Console.ReadLine();
            }
        }
    }
}
