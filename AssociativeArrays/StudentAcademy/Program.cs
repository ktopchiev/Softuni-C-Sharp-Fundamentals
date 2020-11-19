using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsNum = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < rowsNum; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                bool studentExist = studentsAndGrades.ContainsKey(studentName);
                
                if (studentExist)
                {
                    AddStudentAndGrade(studentsAndGrades, studentName, grade);
                }
                else
                {
                    studentsAndGrades.Add(studentName, new List<double>());
                    AddStudentAndGrade(studentsAndGrades, studentName, grade);
                }
            }

            foreach (var pair in studentsAndGrades)
            {
                var avg = pair.Value.Average();
                pair.Value.Clear();
                pair.Value.Add(avg);
            }

            foreach (var pair in studentsAndGrades.Where(x => x.Value[0] >= 4.50).OrderByDescending(x => x.Value[0]))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value[0]:f2}");
            }
        }

        static void AddStudentAndGrade(Dictionary<string, List<double>> studentsAndGrades, string studentName, double grade)
        {
            var gradesList = studentsAndGrades.FirstOrDefault(x => x.Key == studentName).Value;
            gradesList.Add(grade);
        }
    }
}