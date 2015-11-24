using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersofHanoi
{
    public class HanoiTowers
    {
        public void MoveDisk(int diskQuantity,string positionA, string positionB, string positionC)
        {
            if(diskQuantity == 1)
            {
                //Console.WriteLine("Move disk from position {0} to position {1}", positionA, positionC);
                Move(diskQuantity, positionA, positionC);
                return;
            }
            else
            {
                //Move disk from A->B 
                MoveDisk(diskQuantity - 1, positionA, positionC, positionB);

                //Move disk from A->C
                //MoveDisk(1, positionA, positionB, positionC);
                Move(diskQuantity, positionA, positionC);

                //Move disk from B->C
                MoveDisk(diskQuantity - 1, positionB, positionA, positionC);
            }
        }

        private void Move(int diskIndex,string from , string to)
        {
            Console.WriteLine("Move {0} disk from position {1} to position {2}",diskIndex, from, to);
        }
    }
}
