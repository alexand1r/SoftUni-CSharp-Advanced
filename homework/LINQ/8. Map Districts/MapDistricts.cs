﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Map_Districts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, List<long>>();
            var cityPopulations = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            foreach (var pair in cityPopulations)
            {
                var tokens = pair.Split(':');
                var city = tokens[0];
                var district = long.Parse(tokens[1]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<long>());
                }

                cities[city].Add(district);
            }

            var filtered = cities
                .Where(pair => pair.Value.Sum() >= minPopulation)
                .OrderByDescending(pair => pair.Value.Sum());

            foreach (var pair in filtered)
            {
                var districts =
                    pair.Value
                    .OrderByDescending(x => x)
                    .Take(5);
                Console.WriteLine($"{pair.Key}: {string.Join(" ", districts)}");
            }
        }
    }
}
