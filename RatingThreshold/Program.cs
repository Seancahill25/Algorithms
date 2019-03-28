using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingThreshold
{
    class Program
    {
        static void Main(string[] args)
        {
            double threshold = 3.5;
            int[][] ratings = new int[][] 
            {
                new int[] {3,4},
                new int[] {3,3,3,4},
                new int[] {4}
            };

            foreach (var rating in ratingThreshold(threshold, ratings))
            {
                Console.WriteLine(rating);
            }

        }

        public static int[] ratingThreshold(double threshold, int[][] ratings)
        {
            List<int> review = new List<int>();
            double[] totals = new double[ratings.Length];
            double math = 0;

            for (var i = 0; i < ratings.Length; i++)
            {
                for (var j = 0; j < ratings[i].Length; j++)
                {
                    math += ratings[i][j];
                }
                math /= ratings[i].Length;
                totals[i] = math;
                if (totals[i] < threshold)
                {
                    review.Add(Array.IndexOf(totals, totals[i]));
                }
                math = 0;
            }
            return review.ToArray();
        }

    }
}
