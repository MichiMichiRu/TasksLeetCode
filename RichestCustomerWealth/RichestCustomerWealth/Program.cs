using System;

namespace RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] x = { { 1, 2 }, { 3, 4 } };

            int rows = x.GetUpperBound(0)+1;
            int columns = x.Length / rows;
            

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {

                    Console.Write($"{x[i, j]} \t");
                }
                Console.WriteLine();

            }

            /*foreach (int i in x)
            {
                
            }*/
        }
    }
}
