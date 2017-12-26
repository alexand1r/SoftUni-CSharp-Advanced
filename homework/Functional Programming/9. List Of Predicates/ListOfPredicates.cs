﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.List_Of_Predicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> divideList = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();

            Func<int, bool>[] predicates = divideList.Select(div => (Func<int, bool>)(n => n % div == 0)).ToArray();

            for (int i = 1; i <= range; i++)
            {
                bool isDivisable = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisable = false;
                        break;
                    }
                }

                if (isDivisable)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
