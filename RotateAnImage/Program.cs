using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
                int[][] m = new int[][]
                {
                  new int[] { 1, 2, 3 },
                  new int[] { 4, 5, 6 },
                  new int[] { 7, 8, 9 }
                };
                MakeImage(m);

                int[][] rotated = rotateImage(m);

                MakeImage(rotated);
            }

            public static int[][] rotateImage(int[][] m)
            {
                int[][] rotate = new int[m[0].Length][];

                for (int row = 0; row < m[0].Length; row++)
                {
                    rotate[row] = new int[m[0].Length];
                }

                for (int row = 0; row < m[0].Length; row++)
                {
                    for (int column = 0; column < m[0].Length; column++)
                    {
                        rotate[column][row] = m[row][column];
                    }
                }

                for (int row = 0; row < m[0].Length; row++)
                {
                    rotate[row] = rotate[row].Reverse().ToArray();
                }
                return rotate;
            }

            public static void MakeImage(int[][] image)
            {
                foreach (var row in image)
                {
                    foreach (var column  in row)
                    {
                        Console.Write("{0,3}", column);
                    }
                    Console.WriteLine();
                }
            }
        }
}
