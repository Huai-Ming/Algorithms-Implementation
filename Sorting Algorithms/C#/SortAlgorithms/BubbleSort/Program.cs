using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 12, 2, 4, 54, 312, 23, 56, 32, 23 };

            array = BubbleSortHelper.IntArraySort(array);

            foreach(var value in array)
            {
                Console.Write("\t{0}", value);
            }

            Console.Read();
        }
    }
}
