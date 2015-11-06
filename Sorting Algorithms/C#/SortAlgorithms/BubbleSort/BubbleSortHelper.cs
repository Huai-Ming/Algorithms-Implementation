using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// The Bubble Sort algorithm works by repeatedly scanning through the array exchanging adjacent elements that are out of order.
    /// </summary>
    public class BubbleSortHelper
    {
        public static int[] IntArraySort(int[] array)
        {
            //temp variable for store the value pending exchanged
            int temp = 0;
           
            // For simple bubble sort, it will always be n-1 passes, we can add a flag to decrease the passes.
            bool flag = true;

            for (int i = 0; i < array.Length && flag; i++)
            {
                flag = false;
                for(int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        //Swap the value of adjacent element value
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        flag = true;
                    }
                }

                foreach (var value in array)
                {
                    Console.Write("\t{0}", value);
                }
                Console.WriteLine();
            }

           

            return array;
        }
    }
}
