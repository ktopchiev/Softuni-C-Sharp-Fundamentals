using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(':').ToArray();
                string courseName = input[0];
                
                if (courseName == "end")
                {
                    break;
                }
                
                string registeredStudent = input[1];
                bool courseExist = courses.ContainsKey(courseName);

                if (!courseExist)
                {
                    courses.Add(courseName, new List<string>());
                    AddStudentToCourseList(courses, courseName, registeredStudent);
                }
                else
                {
                    AddStudentToCourseList(courses, courseName, registeredStudent);   
                }
            }

            foreach (var pair in courses.OrderByDescending(course => course.Value.Count))
            {
                Console.WriteLine($"{pair.Key.TrimEnd()}: {pair.Value.Count}");
                foreach (var student in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student.TrimStart()}");
                }
            }
        }

        static void AddStudentToCourseList(Dictionary<string, List<string>> courses, string courseName, string student)
        {
            var studentsList = courses.FirstOrDefault(x => x.Key == courseName).Value;
            studentsList.Add(student);
        }
    }
}