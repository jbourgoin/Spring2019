using SmartArrayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SMART_ARRAY_SIZE = 5;

            SmartArray mySmartArray = new SmartArray(SMART_ARRAY_SIZE);

            mySmartArray.SetAtIndex(3, 333);
            mySmartArray.SetAtIndex(4, 444);
            int total = mySmartArray.GetAtIndex(3) + mySmartArray.GetAtIndex(4);
            Console.WriteLine("Hope this comes out as 777!   {0}", total);
            Console.WriteLine();
            Console.WriteLine();
            mySmartArray.PrintAllElements();
            Console.WriteLine();
            bool yes = mySmartArray.Find(333);
            Console.WriteLine("There is a 333 value in the array? {0}", yes);


            //my code
            mySmartArray.SetAtIndex(0, 0);
            mySmartArray.SetAtIndex(1, 0);
            mySmartArray.SetAtIndex(2, 0);
            mySmartArray.SetAtIndex(3, 0);
            mySmartArray.SetAtIndex(4, 0);
            mySmartArray.PrintAllElements();

            int actual = 0;
            int temp = 0;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                actual = mySmartArray.GetAtIndex(i) + 1;
                mySmartArray.SetAtIndex(i, actual);


                temp = temp + mySmartArray.GetAtIndex(i);
                actual = actual * 0 + temp;
            }
            Console.WriteLine("actual value after for loop: "+actual);
            Console.WriteLine("some temp value after for loop "+temp);
            Console.WriteLine();
            mySmartArray.PrintAllElements();

            //end my code
           
            Console.ReadLine();
        }
    }
}
