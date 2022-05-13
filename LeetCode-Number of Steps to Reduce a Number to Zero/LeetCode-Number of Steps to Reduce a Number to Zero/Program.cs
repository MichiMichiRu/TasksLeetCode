using System;
using System.Linq;
using System.Collections.Generic;


namespace LeetCode_Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    class Program
    {
        public static int NumberOfSteps(int num)
        {
            int count = 0;
            int x = num;

            while (x > 0)
            {
                ++count;

                if (x % 2 > 0)
                {
                    //Console.WriteLine("Step {0}) {1} is odd. Subtract by 1 and obtain by {2}", count, x, x - 1);
                    x--;
                    //count++;
                }
                else
                {
                    //Console.WriteLine("Step {0}) {1} is even. Divide by 2 and obtain by {1}", count, x, x - 1);
                    x /= 2;
                    //count++;
                }


            }
            Console.WriteLine(count);
            return count;
        }

        static void Main(string[] args)
        { 
            NumberOfSteps(int.Parse(Console.ReadLine()));

        }
    }
    
}