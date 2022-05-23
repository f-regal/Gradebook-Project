// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Scott!");

using System;

namespace GradeBook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var numbers = new[] {1.1, 2.2, 3.3};
            var Grades = new List<double>() {12.7, 10.3, 6.11, 4.1};



            var sum = 0.0;

            foreach(var num in Grades) {
                sum += num;
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum/(Grades.Count));
        }
    }
}
