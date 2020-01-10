using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInfo = new Dictionary<string, List<double>>();

            int numNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numNames; i++)
            {
                var nameAndGrade = Console.ReadLine()
                    .Split();
                string name = nameAndGrade[0];
                double grade = double.Parse(nameAndGrade[1]);
                if (!studentInfo.ContainsKey(name))
                {
                    studentInfo.Add(name, new List<double>());
                }
                studentInfo[name].Add(grade);
            }

            foreach (var student in studentInfo)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2"))):F2} (avg:{student.Value.Average():F2})");
            }
        }
    }
}
