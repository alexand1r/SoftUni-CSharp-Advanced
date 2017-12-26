﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Weak_Students
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string[]> students = new List<string[]>();

            while (input != "END")
            {
                students.Add(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                input = Console.ReadLine();
            }

            List<string[]> result = students.Where(s => s.Skip(2).Count(m => int.Parse(m) <= 3) >= 2).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
