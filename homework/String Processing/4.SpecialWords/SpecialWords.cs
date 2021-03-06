﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SpecialWords
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            var specialWords = Console.ReadLine().Split(' ');
            var text = Console.ReadLine().Split(new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var words = new Dictionary<string, int>();

            foreach (var currentSpecialWord in specialWords)
            {
                var counter = 0;
                var foundIndex = 0;
                var indexOfWord = Array.IndexOf(text, currentSpecialWord, foundIndex);

                while (indexOfWord != -1)
                {
                    ++counter;
                    foundIndex = indexOfWord;
                    indexOfWord = Array.IndexOf(text, currentSpecialWord, foundIndex + 1);
                }

                words.Add(currentSpecialWord, counter);
            }

            foreach (var pair in words)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
