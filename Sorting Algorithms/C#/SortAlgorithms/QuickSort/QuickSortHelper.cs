using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortHelper
    {
        public static int[] QuickSort(int[] numbers, int left, int right)
        {
            if(left >= right)
            {
                return numbers;
            }
            Console.WriteLine("Left:{0};Right:{1}", left, right);
            int pivot = Partition(numbers, left, right);
            
            //Here we will sort by recursion.
            //Sort the left side
            if(pivot > left + 1 )
            {
                Console.WriteLine("Left:{0};Right:{1}", left, pivot - 1);
                QuickSort(numbers, left, pivot - 1);// Note: that's the trick.
            }

            //Sort the right side
            if(pivot + 1 < right)
            {
                Console.WriteLine("Left:{0};Right:{1}", pivot + 1, right);
                QuickSort(numbers, pivot + 1, right);
            }


            return numbers;
        }

        public static int Partition(int[] numbers, int left, int right)
        {
            //to set the pivot vlaue as the left number
            int key = numbers[left];

            while(left < right)
            {
                while (numbers[right] >= key && left < right)
                    right--;

                int temp = numbers[right];
                numbers[right] = numbers[left];// pivot
                numbers[left] = temp;

                while (numbers[left] <= key && left < right)
                    left++;

                temp = numbers[right];//pivot
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\t{0}", numbers[i]);
            }

            return right;
        }

    }
}
