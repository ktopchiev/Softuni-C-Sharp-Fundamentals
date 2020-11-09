using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<string> listOfStudents = new List<string>();
            List<Student> sortedListOfStudents = new List<Student>();
            
            for (int i = 0; i < countOfStudents; i++)
            {
                listOfStudents = Console.ReadLine().Split(' ').ToList();
                
                string firstName = listOfStudents[0];
                string lastName = listOfStudents[1];
                float grade = float.Parse(listOfStudents[2]);
                
                Student newStudent = new Student(firstName, lastName, grade);
                
                sortedListOfStudents.Add(newStudent);
            }

            foreach (var student in sortedListOfStudents.OrderByDescending(x=>x.grade))
            {
                Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:f2}");
            }
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public float grade { get; set; }
        
        public Student(string firstName, string lastName, float grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }
    }
}