using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackClass;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // try the constructor
        public void DoesConstructorThrowException()
        {
            OurStack testStack = new OurStack((char)10);
            
        }

        [TestMethod]
        // try the myStack.IsEmpty_empty() property
        public void IsEmptyPropEmpty()
        {
            OurStack testStack = new OurStack((char)10);
            Assert.AreEqual(true, testStack.IsEmpty());
        }

         [TestMethod]
        // try the myStack.IsEmpty_notempty() property
        public void IsEmptyPropNotEmpty()
        {
            OurStack testStack = new OurStack((char)10);
            testStack.Push((char)77);
            Assert.AreEqual(false, testStack.IsEmpty());
        }

         [TestMethod]
         // try the myStack.IsEmpty_empty() property after pushing and popping
         public void IsEmptyAfterPopPropEmpty()
         {
             OurStack testStack = new OurStack((char)10);
             testStack.Push((char)77);
             testStack.Pop();
             Assert.AreEqual(true, testStack.IsEmpty());  
         }

         [TestMethod]
         // try the OverflowException when no room left in backing array
         [ExpectedException(typeof(OverflowException))]
         public void OverflowExceptionTest()
         {
             OurStack testStack = new OurStack((char)3);
             testStack.Push((char)77);
             testStack.Push((char)77);
             testStack.Push((char)77);
             testStack.Push((char)77);
         }

         [TestMethod]
        // try the IndexOutOfRangeException when try and pop and empty stack
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfRangeExceptionTest()
        {
            OurStack testStack = new OurStack((char)3);
            int x = testStack.Pop();
        }

         [TestMethod]
         // try the OverflowException when no room left in backing array, test message
         public void OverflowExceptionMessage()
         {
            string expected = "Stack is full";
            string actual = "";

            try
            {
                OurStack testStack = new OurStack((char)3);
                testStack.Push((char)77);
                testStack.Push((char)77);
                testStack.Push((char)77);
                testStack.Push((char)77);
            }
            catch (OverflowException ex)
            {
                actual = ex.Message;
            }
            finally {
                Assert.AreEqual(expected, actual);
            }
         }

         [TestMethod]
         // try the myStack.Peek() method
         public void PeekTest()
         {
            OurStack testStack = new OurStack((char)3);
            char expected = (char)42;
            testStack.Push(expected);
            int actual = testStack.Peek();
            Assert.AreEqual(expected, actual, "Peek() returned the wrong value");
         }

         [TestMethod]
         // try the myStack.Peek() method again to make sure still there
         public void PeekAgainTest()
         {
            OurStack testStack = new OurStack((char)3);
            char expected = (char)42;
            testStack.Push(expected);
            int actual = testStack.Peek();
            Assert.AreEqual(expected, actual, "Peek() returned the wrong value");
         }
        
         [TestMethod]
         //empty the stack
         public void EmptyStackTest()
         {
            OurStack testStack = new OurStack((char)3);
            Assert.IsTrue(testStack.IsEmpty());
         }
    }
}


