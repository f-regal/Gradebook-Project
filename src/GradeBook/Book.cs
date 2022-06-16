using System;

namespace GradeBook {
  class Book
    {
        
        public Book()
        {
            grades = new List<double>();
        }
      
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStats()
        {
            var result = 0.0;
            foreach(var num in grades) {
                result += num;
            }
            result /= grades.Count();
            Console.WriteLine($"Average result: {result:N1}");
            Console.WriteLine($"Max result: {grades.Max():N1}");
            Console.WriteLine($"Lowest result: {grades.Min():N1}");
        }

        List<double> grades;

    }
}
  
