using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[,] multiDim = new int[4, 4];
            for (int i = 0; i < multiDim.GetLength(0); i++)
            {
                for (int j = 0; j < multiDim.GetLength(1); j++)
                {

                    multiDim[i, j] = Convert.ToInt32(Console.In.ReadLine());
                    //Console.WriteLine(multiDim[i, j]);
                }

            }

            for (int i = 0; i < multiDim.GetLength(0); i++)
            {
                for (int j = 0; j < multiDim.GetLength(1); j++)
                {
                    Console.WriteLine(multiDim[i, j]);
                }
            }





        }
    }
}
