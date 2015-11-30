using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class ShellSortHelper<T> where T : IComparable
    {
        public static void Sort(T[] entries)
        {
            ShellSort(entries);
        }
                /**
        * Shell sort - sort with diminishing increment (descending)
        * @param array to be sorted
        */
        public static void ShellSort(T[] entries)
        {
            int gap = entries.Length / 2;
            while (gap > 0)
            {
                for (int i = 0; i < entries.Length - gap; i++) //modified insertion sort
                {
                    int j = i + gap;
                    var entry = entries[j];
                    while (j >= gap && entries[j - 1].CompareTo(entry) > 0)
                    {
                        entries[j] = entries[j - gap];
                        j -= gap;
                    }
                    entries[j] = entry;
                }
                if (gap == 2) //change the gap size
                {
                    gap = 1;
                }
                else
                {
                    gap = (int)(gap / 2.2);
                }
            }
        }
    }
}
