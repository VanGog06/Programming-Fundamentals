/*
Define a class Student, which holds the following information about students: name, list of grades and average grade (calculated property, read-only). A single grade will be in range [2…6], e.g. 3.25 or 5.50.
Read a list of students and print the students that have average grade ≥ 5.00 ordered by name (ascending), then by average grade (descending). Print the student name and the calculated average grade.

Examples
Input	                        Output
3                               Diana -> 5.75
Ivan 3                          Todor -> 5.33
Todor 5 5 6
Diana 6 5.50	

6                               Ani -> 5.58
Petar 3 5 4 3 2 5 6 2 6         Ani -> 5.50
Mitko 6 6 5 6 5 6               Gosho -> 6.00
Gosho 6 6 6 6 6 6               Mitko -> 5.67
Ani 6 5 6 5 6 5 6 5
Iva 4 5 4 3 4 5 2 2 4
Ani 5.50 5.25 6.00	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                List<string> studentArgs = Console.ReadLine().Split().ToList();

                string name = studentArgs[0];
                List<double> grades = studentArgs.Skip(1).Select(e => double.Parse(e)).ToList();

                Student student = new Student() { Name = name, Grades = grades };

                students.Add(student);
            }

            foreach (var student in students.Where(e => e.averageGrade >= 5.00).Select(e => e).OrderBy(e => e.Name).ThenByDescending(e => e.averageGrade))
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.averageGrade);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double averageGrade
        {
            get
            {
                return Grades.Sum() / (double)Grades.Count();
            }
        }
    }
}
