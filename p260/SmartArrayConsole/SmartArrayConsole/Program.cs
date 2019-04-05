using System;

namespace SmartArrayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartArray mySmartArray = new SmartArray(10);
            mySmartArray.SetAtIndex(2, 102);
            mySmartArray.SetAtIndex(4, 104);
            mySmartArray.PrintAllElements();
            Console.WriteLine();

            int x = mySmartArray.GetAtIndex(4);
            Console.WriteLine("x is {0}", x);
            Console.WriteLine();

            bool found = mySmartArray.Find(102);
            Console.WriteLine(found);

            mySmartArray.Resize(5);
            mySmartArray.SetAtIndex(2, 102);

            mySmartArray.PrintAllElements();


            Console.ReadLine();
        }

    }
}
