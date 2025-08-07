using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter course code {i + 1}: ");
                
                string input = Console.ReadLine().Trim();

                if (input.Length != 5)
                {
                    Console.WriteLine($"Error: Course code must be 5 characters long.");
                    continue;
                }
                courses.Add(input);
                
                Console.WriteLine($"Successfully added course: {input}");
            }
            
            Console.WriteLine("\nValid Courses:");
            
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
