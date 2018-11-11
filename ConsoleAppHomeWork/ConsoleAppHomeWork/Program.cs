using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Matrix = new int[3][];
            int i, j;
            Matrix[0] = new int[3] { 1, 2, 3 };
            Matrix[1] = new int[3] { 4, 5, 6 };
            Matrix[2] = new int[3] { 7, 8, 9 };
            for (i = 0; i < Matrix.Length; i++)
            {
                for (j = 0; j < Matrix.Length; j++)
                {
                    Console.Write(Matrix[i][j] + "   ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Check Array --> ");
            Console.WriteLine("================");
            for (i = 0; i < Matrix.Length; i++)
            {
                for (j = 0; j < Matrix.Length; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(Matrix[i][j] + " Main diagonal");
                    }
                }
            }
            Console.WriteLine("================");
            Console.WriteLine("================");
            for (i = 0; i < Matrix.Length; i++)
            {
                for (j = 0; j < Matrix.Length; j++)
                {
                    if (i + j == Matrix.Length - 1)
                    {
                        Console.WriteLine(Matrix[i][j] + " Secound diagonal");
                    }
                }
            }
            Console.WriteLine("================");
            Console.WriteLine("=======================");
            for (i = 0; i < Matrix.Length; i++)
            {
                for (j = 0; j < Matrix.Length; j++)
                {
                    if (i >j)
                    {
                        Console.WriteLine(Matrix[i][j] + " Under the main diagonal");
                    }
                }
            }
            Console.WriteLine("=======================");
            Console.WriteLine("=======================");
            for (i = 0; i < Matrix.Length; i++)
            {
                for (j = 0; j < Matrix.Length; j++)
                {
                    if (i < j)
                    {
                        Console.WriteLine(Matrix[i][j] + " Above the main diagonal");
                    }
                }
            }
            Console.WriteLine("=======================");
        }
    }
}
