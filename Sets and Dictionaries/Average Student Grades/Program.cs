using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());

            var studentRecords = new Dictionary<string, List<double>> ();

            for (int i = 0; i < numInputs; i++)
            {
                var studentInfo = Console.ReadLine()
                    .Split();
                var studentName = studentInfo[0];
                var studentGrade = double.Parse(studentInfo[1]);

                if (!studentRecords.ContainsKey(studentName))
                {
                    studentRecords[studentName] = new List<double>();
                }
                studentRecords[studentName].Add(studentGrade);
            }

            foreach (var student in studentRecords)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
