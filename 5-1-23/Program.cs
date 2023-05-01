using System;

namespace CodingChallenges
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            int rounds = 0;
            Console.Write("Please enter the number: ");
            int num = int.Parse(Console.ReadLine());

            while(num != 1)
            { 
                if(num % 2 == 0)
                {
                    rounds++;
                    num = num / 2;
                } 
                else
                {
                    rounds++;
                    num = (num * 3) + 1;
                }
            }

            Console.WriteLine(rounds.ToString());
        }
    }
}