using System;
using System.Collections.Generic;
using System.Text;

namespace SmartArrayConsole
{
    public class SmartArray
    {
        int[] UnderlyingArray; // using the C# simple array to hold our data

        public SmartArray(int origSize)  // constructor sets initial size
        {
            UnderlyingArray = new int[origSize];
        }

        public void SetAtIndex(int index, int val)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("too small");
            }
            else if (index > UnderlyingArray.Length - 1)
            {
                throw new IndexOutOfRangeException("too big");
            }
            else
            {
                UnderlyingArray[index] = val;
                return;
            }
        }

        public int GetAtIndex(int index)
        {
            try
            {
                return UnderlyingArray[index];
            }
            catch (Exception)
            {

                if (index < 0)
                {
                    throw new IndexOutOfRangeException("too small");
                }
                else if (index > UnderlyingArray.Length - 1)
                {
                    throw new IndexOutOfRangeException("too big");
                }
            }
            finally
            {

            }
            return Int32.MinValue;
        }

        public void PrintAllElements()
        {
            for (int i = 0; i < UnderlyingArray.Length; i++)
            {
                Console.WriteLine(UnderlyingArray[i]);
            }
        }

        public bool Find(int val)
        {
            for (int i = 0; i < UnderlyingArray.Length; i++)
            {
                if (UnderlyingArray[i] == val)
                {
                    return true;
                }
            }
            return false;
        }

        public void Resize(int newsize)
        {
            int[] tempArray = new int[newsize];
            int size = UnderlyingArray.Length;

            if (newsize < size)
            {
                //temp array is smaller than UnderlyingArray
                size = newsize;
            }
            else if (tempArray.Length > UnderlyingArray.Length)
            {
                //temp array is larger than UnderlyingArray
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = UnderlyingArray[i];
                }
            }
            //re-assign temp array and values to UnderlyingArray
            UnderlyingArray = tempArray;
        }


    } // end of SmartArray class
}
