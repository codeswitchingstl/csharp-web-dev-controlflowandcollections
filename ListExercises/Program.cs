using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> nums = new List<int> { 1, 2, 4, 6, 7, 9, 12, 14, 19, 22 };
            ListStuff.SumEven(nums);

            List<string> wordList = new List<string> { "earth", "right", "faces", "pumpkin", "fuzzy", "pencil", "band", "gum", "moon", "rocket", "puppy", "was" };
           

        }

        public class ListStuff
        {
            public static int SumEven(List<int> nums)
            {
                int total = 0;
                foreach (int integer in nums)
                {
                    if (integer % 2 == 0)
                    {
                        total += integer;
                    }
                }
                Console.WriteLine(total);
                return total;
            }

            public static void printFiveLetterWords(List<string> wordlist)
            {
                foreach (string word in wordlist)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                        return;
                    }
                }
            }
        }
    }
}
