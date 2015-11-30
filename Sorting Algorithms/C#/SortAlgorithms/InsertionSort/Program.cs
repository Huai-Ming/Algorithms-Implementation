using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Insertion Sort
            int[] array = new int[]{9,7,4,3,2,5,10,1,43,22};
            InsertionSortHelper<int>.Sort(array);
            Console.WriteLine(string.Join(",", array));
            #endregion

            #region Shell Sort
            int[] array1 = new int[] { 9, 7, 4, 3, 2, 5, 10, 1, 43, 22 };
            InsertionSortHelper<int>.Sort(array1);
            Console.WriteLine(string.Join(",", array1));
            #endregion
            Console.Read();

        }
    }
}
