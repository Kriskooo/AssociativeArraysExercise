using System;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            // буква -> бр.срешания
            Dictionary<char, int> words = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == ' ')
                {
                    continue;
                }
                // да го има в речника
                // да го няма в речника
                if (words.ContainsKey(symbol))
                {
                    words[symbol]++;
                }
                else
                {
                    words.Add(symbol, 1);
                }
            }

            foreach (var pair in words)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
