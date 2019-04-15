using StackClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOurStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if input word is a palindrome: ");
            char[] userInput = Console.ReadLine().ToLower().ToCharArray();
            int strLength = userInput.Count();

            OurStack myStack = new OurStack((char)strLength);  // build a short stack, easier to test edge conditions
            bool isPalandrome = false;
            Console.WriteLine(userInput);

            Console.WriteLine();

            //pushing user input into the stack
            foreach (char character in userInput)
            {
                myStack.Push(character);
            }

            for (int i = 0; i < userInput.Count(); i++)
            {
                if (userInput[i] != myStack.Pop()) //if any letter doesn't match..
                {
                    Console.WriteLine("not a palindrome");
                    break;
                }
                else
                {
                    isPalandrome = true;
                }
            }

            //if all characters match appropriate positions then success!
            if (isPalandrome)
            {
                Console.WriteLine("congrats it's a word backwards and forwards! xD");
            }


            // students write program that asks for a word, then 
            // tells if was an Palindrome or not.

            // good words:  rotator  deified  reviver  civic  kayak  level  radar  tenet

            // algo:
            // split the letters into a char array
            // push the letters into our stack so can read them in reverse order
            // compare left to rigth [] with right to left (stack.Pop)
            // count of success will = length of word if success


            Console.ReadLine();
        }

    }
}