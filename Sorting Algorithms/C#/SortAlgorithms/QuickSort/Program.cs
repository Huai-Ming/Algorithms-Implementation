using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbers.Length;

            // 3, 8, 7, 5, 2, 1, 9, 6, 4 ;
            //left = 0; right = 8; pivot = 3;

            //left = 0; right = 5; pivot = 3;
            //1,8,7,5, 2, 3, 9, 6, 4,

            //left = 1, right = 5; pivot = 3;

            //1,3,7, 5, 2, 8,9,6,4

            //left = 1; right = 4, pivot = 3;

            //1,2,7, 5, 3, 8, 9, 6, 4;

            //left = 2; right = 4, pivot = 3;
            //1,2,3, 5, 7, 8, 9, 6, 4;


            Console.WriteLine("QuickSort By Recursive Method");
            numbers = QuickSortHelper.QuickSort(numbers, 0, len - 1);
            for (int i = 0; i < len; i++)
            {
                Console.Write("\t{0}", numbers[i]);
            }

            Console.Read();
        }
    }
}
