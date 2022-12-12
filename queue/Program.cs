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
                Console.WriteLine("\nQueue overflow\n");
                return;
            }

            /* This following statement check the queue is empty. if the queue is empty
             * then the value of the REAR and  FRONT variables is set to 0 */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the position of the array. then the value of
                 * RAER is set to 0 that corresponds to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at the lasrt position, then its value is incremented by one */
                    REAR = REAR + 1;
            }
            /* Once the position of RAER is deterwined, the element is added at its proper place */
            queue_array[REAR] = element;
        }
        static void Main(string[] args)
        {
        }
    }
}
