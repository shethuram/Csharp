using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        //  Sample Data
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ram", Grade = 85, Age = 20 },
            new Student { Name = "John", Grade = 72, Age = 21 },
            new Student { Name = "Peter", Grade = 90, Age = 19 },
            new Student { Name = "Vijay", Grade = 65, Age = 22 },
            new Student { Name = "Ajith", Grade = 88, Age = 20 }
        };

        //  Threshold
        int threshold = 80;

        //  LINQ: Filter + Sort
        var filteredStudents = students
            .Where(s => s.Grade > threshold)
            .OrderBy(s => s.Name)
            .ToList();

        //  Display Results
        Console.WriteLine("Students with Grade > " + threshold + ":\n");

        foreach (var s in filteredStudents)
        {
            Console.WriteLine($"Name: {s.Name}, Grade: {s.Grade}, Age: {s.Age}");
        }
    }
}