using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSortHelper<T> where T: IComparable
    {
        public static void Sort(T[] entries)
        {
            Sort(entries, 0, entries.Length - 1);
        }

        public static void Sort(T[] entries, Int32 first, Int32 last)
        {
            for (var i = first + 1; i <= last; i++)
            {
                //We will set the first value from entries[1];
                var entry = entries[i];
                var j = i;

                //First we will compare entries[1] > entries[0]
                //Traverse the entries from entries[0] to entries[j-1]
                while (j > first && entries[j - 1].CompareTo(entry) > 0)
                    entries[j] = entries[--j];

                entries[j] = entry;
            }
        }
    }
}
