using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string companyInput = input[0];
                
                if (companyInput == "End")
                {
                    break;
                }

                string employeeId = input[1];
                bool companyExist = companies.ContainsKey(companyInput);

                if (companyExist && !companies[companyInput].Contains(employeeId))
                {
                    companies[companyInput].Add(employeeId);
                }
                else if (!companyExist)
                {
                    companies.Add(companyInput, new List<string>());
                    var companyList = companies.FirstOrDefault(x => x.Key == companyInput).Value;
                    companyList.Add(employeeId);
                }
            }

            foreach (var pair in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(pair.Key);
                
                foreach (var employeeId in pair.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}