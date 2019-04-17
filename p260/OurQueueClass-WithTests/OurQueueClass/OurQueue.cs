using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurQueueClass
{
    public class OurQueue
    {
        private int qTop;
        private int qBottom;  // is really a pointer to the next unused slot in the array
        
        int [] ourData; // underlying array to hold the data

        private int counter;

        public int QCount  // propery to get size of queue
        {
            get { return counter; }
           // set { counter = value; }  do not let outside program change this value
        }
        
        
        public OurQueue (int qSize)  // constructor
	    {
            qTop = 0;
            qBottom = 0;
            counter = 0;
            ourData = new int[qSize];
	    }

     

        public void Enqueue(int newItem)
        {
            if (counter >= ourData.Length)
            {
                throw new OverflowException("Q is full");
            }
            
            counter++;
            ourData[qBottom] = newItem;
            qBottom = qBottom + 1;

            if (qBottom == ourData.Length)
            {
                qBottom = 0;
            }
        }

        public int Dequeue()
        {
            if (counter == 0)
            {
                throw new IndexOutOfRangeException("Q is empty");  // again, there is no "underflow" exception, so using this one
            }
            int returnValue = ourData[qTop];
            counter--;
            qTop = qTop + 1;

            if (qTop == ourData.Length)
            {
                qTop = 0;
            }

            return returnValue;

        }

        public bool IsEmpty()
        {
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Peek()
        {
            if (counter == 0)
            {
                throw new IndexOutOfRangeException("Q is empty");
            }
            else
	        {
                return ourData[qTop];
	        }
       }

        public void Clear()
        {
            qTop = 0;
            qBottom = 0;
            counter = 0;
        }
    }
}
