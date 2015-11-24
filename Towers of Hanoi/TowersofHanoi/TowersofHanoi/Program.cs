using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersofHanoi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HanoiTowers hanoi = new HanoiTowers();
            Console.WriteLine("Please input Disk Quantity:");
            int DiskQuantity = Convert.ToInt32(Console.ReadLine());
            hanoi.MoveDisk(DiskQuantity, "A", "B", "C");
            Console.ReadKey();
        }
    }
}
