using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProjectStack
{
    [TestClass]
    public class UnitTest1
    {
        // verify that a newly created stack has no entries
        [TestMethod]
        public void IsInitialStackEmpty()
        {
            Stack<int> TestStack = new Stack<int>();
            int expected = 0;
            int actual = TestStack.Count;
            Assert.AreEqual(expected, actual, "stack was not zero length");
        }

        // verify that a stack after 3 entries is not empty
        [TestMethod]
        public void IsStackEmptyAfterPushes()
        {
            Stack<int> TestStack = new Stack<int>();

            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);
            int isEmpty = TestStack.Count;

            Assert.AreNotEqual(0, isEmpty,"Stack count is 0 after adding");
        }

        [TestMethod]
        public void PeekWorks()
        {
            Stack<int> TestStack = new Stack<int>();
            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);

            int actual = (int)TestStack.Peek();
            Assert.AreEqual(30, actual,0.000001,"Peek does not match last value pushed to the stack.");

        }

        [TestMethod]
        //verify pop works after three pushes
        public void PopAfterThreePushes()
        {
            Stack<int> TestStack = new Stack<int>();
            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);

            int actual = (int)TestStack.Pop();

            Assert.AreEqual(30, actual,0.00001,"Stack does not match expected top value");

        }

        [TestMethod]
        //verify empty after three pushes and three pushes
        public void IsEmptyAfterThreePopsAndPushes()
        {
            Stack TestStack = new Stack();
            TestStack.Push(10);
            TestStack.Push(20);
            TestStack.Push(30);
            TestStack.Pop();
            TestStack.Pop();
            TestStack.Pop();

            Assert.AreEqual(0, TestStack.Count,"pops did not work.");

        }
    }
}
