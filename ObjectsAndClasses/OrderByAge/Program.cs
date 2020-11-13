using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains("End"))
                {
                    break;
                }

                string id = input[1];
                int age = int.Parse(input[2]);
                
                Person person = new Person(input[0], id, age);
                persons.Add(person);
            }

            var orderedPersons = persons.OrderBy(x => x.Age).ToList();
            
            foreach (var person in orderedPersons)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name.First().ToString().ToUpper() + Name.Substring(1)} with ID: {ID} is {Age} years old.");
            return sb.ToString().TrimEnd();
        }
    }
}