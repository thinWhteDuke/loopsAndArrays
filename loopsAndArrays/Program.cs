using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loopsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays[]
            //instead of writing one by one, i can use arrays to write and add something to one value with an array

            string[] names = new string[3];

            names[0] = "Douglas";
            names[1] = "Raphael";
            names[2] = "Katerina";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int[] numbers = { 2, 3, 5, 1, 4 };
            int largestNumber = numbers.Max();
            Console.WriteLine(largestNumber);
            
            Console.WriteLine(numbers.Min());
            
            Console.WriteLine(numbers.Sum());
            
            Console.WriteLine(numbers.Length);
            
            Console.WriteLine(numbers.Average());
            
            Console.WriteLine(numbers.Contains(3));
            
            Console.ReadKey();
        }
    }
}
