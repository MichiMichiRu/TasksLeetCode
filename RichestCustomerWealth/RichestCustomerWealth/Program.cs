using System;

namespace RichestCustomerWealth
{
    class Program
    {

        /*int MaximumWealth(int[][] accounts)
        {
            int[][] nums = accounts;

            int maxSumm;


            return maxSumm;
        }*/

        static void Main(string[] args)
        {
            int dim0 = 5;
            int dim1 = 10;
            int dim2 = 6;

            int[][][] threeDimArray = new int[dim0][][];
            for (int idx0 = 0; idx0 < dim0; ++idx0)
            {
                int[][] twoDimArray = new int[dim1][];
                for (int idx1 = 0; idx1 < dim1; ++idx1)
                {
                    int[] oneDimArray = new int[dim2];
                    for (int idx2 = 0; idx2 < dim2; ++idx2)
                    {
                        oneDimArray[idx2] = idx0 * idx1 * idx2;
                        Console.Write(idx2);
                    }
                    twoDimArray[idx1] = oneDimArray;
                    Console.WriteLine(idx1);
                }
                threeDimArray[idx0] = twoDimArray;
                Console.WriteLine(idx0);
            }


        }
    }
}
