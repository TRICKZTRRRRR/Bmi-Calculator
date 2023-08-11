using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI Calculator";

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Weigth");
                string cmWeight = Console.ReadLine();
                Console.WriteLine("\r\nHeight");
                string cmHeight = Console.ReadLine();

                double cmW, cmH;
                double.TryParse(cmWeight, out cmW);
                double.TryParse(cmHeight, out cmH);

                double cmCalculation = (cmW / Math.Pow((cmH), 2)) * 10000;

                Console.WriteLine("\r\nBMI = " + cmCalculation.ToString("0.##"));

                if (cmCalculation < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You are underweight");
                }
                else if (cmCalculation >= 18.5 && cmCalculation < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are Normal weight");
                }
                else if (cmCalculation >= 25 && cmCalculation < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are Obese");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You are too Fat");
                }
                Console.ReadLine();
            }
        }
    }
}
