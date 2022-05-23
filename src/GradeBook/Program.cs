// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Scott!");

using System;

namespace GradeBook // Note: actual namespace depends on the project name.
// Up Next: Adding a Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            // var sum = 0.0;

            // foreach(var num in grades) {
            //     sum += num;
            // }

            // Console.WriteLine(sum);
            // Console.WriteLine(sum/(Grades.Count));

            foreach(var grade in grades) {
                System.Console.WriteLine(grade);
            }
        }
    }
}
