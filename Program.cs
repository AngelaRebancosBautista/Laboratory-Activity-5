using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int validAge;
            float validHeight;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            validAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your height (in meters): ");
            validHeight = float.Parse(Console.ReadLine());

            if (!string.IsNullOrWhiteSpace(name) && validAge > 0 && validHeight > 0)
            {
                Console.WriteLine($"Name: {name}, Age: {validAge}, Height: {validHeight}");
            }
            else
            {
                Console.WriteLine("Please enter valid data for all fields.");
            }
        }
    }
}




