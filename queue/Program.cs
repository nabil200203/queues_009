using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{

    internal class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*initializing the values of the variables REAR and FRONT to -1 to indicate that
             * the name is initiall;y empty,*/

            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            /*This statement check for the overflow condition. */
            if ((FRONT == 0 && REAR == max -1) ||(FRONT == REAR +1))
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
