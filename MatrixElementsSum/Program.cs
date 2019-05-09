using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixElementsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = {
            new int[] { 4, 0, 1},
            new int[] { 10, 7, 0},
            new int[] { 0, 0, 0},
            new int[] { 9, 1, 2}
            };

            Console.WriteLine(matrixElementsSum(matrix));
        }

        public static int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {

                    if (matrix[i][j] == 0 && i + 1 < matrix.Length)
                    {
                        matrix[i + 1][j] = 0;
                    }

                    sum += matrix[i][j];
                }
            }
            return sum;
        }
    }
}
