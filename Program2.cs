using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };


            Console.WriteLine("Original Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[,] transpose = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }


            Console.WriteLine("\nTranspose of the Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(transpose[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Created by Ankit Verma ");
            Console.WriteLine("MCA-I A, Roll No: 14");
            Console.ReadLine();
        }
    }
}
