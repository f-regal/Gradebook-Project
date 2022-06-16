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
            // var grades = new List<double>() {10.0,10.0,10.0,10.0};
            // book.grades = new List<double> {1.0, 2.0, 3.0};
            book.AddGrade(100.0);
            book.AddGrade(80.0);
            book.AddGrade(60.0);
            book.showStats();

    
        }
    }
}
