using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = {1, 2, 3};
            Console.Write("Second Largest num: ");
            SecondMax(ints);

            string s = "ab1231da";
            AddDigits(s);
        }

        private static void AddDigits(string s)
        {
            char[] chars = s.ToCharArray();
            int sum = 0;
            foreach(char c in chars)
            {
                if (!char.IsLetter(c))
                {
                    sum += int.Parse(c.ToString());
                }
            }
            Console.WriteLine("Sum of " + s + " is: " + sum);
        }

        private static void SecondMax(int[] list)
        {
            // Write a program that accepts sets of three numbers,
            // and prints the second-maximum number among the three.
            int a = list[0];
            int b = list[1];
            int c = list[2];
            
            if(a > b && a > c)
            {
                if(b > c)
                {
                    Console.WriteLine(b);
                } else
                {
                    Console.WriteLine(c);
                }
            }
            else if(b > c && b > a)
            {
                if(c > a)
                {
                    Console.WriteLine(c);
                } else
                {
                    Console.WriteLine(a);
                }
            }
            else if(a > b)
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine(b);
            }
        }
    }
}