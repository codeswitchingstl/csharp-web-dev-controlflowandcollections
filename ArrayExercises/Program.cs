using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 1, 1, 2, 3, 5, 8 };
            //original version of loop
            foreach (int num in numberArray)
            {
                Console.WriteLine(num);
            }

            //loop to print only odd numbers
            foreach (int num in numberArray)
            {
                if (num % 2 != 0)
                    Console.WriteLine(num);
            }
        }
    }
}
