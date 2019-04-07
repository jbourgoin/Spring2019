using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartArrayLibrary;

namespace UnitTestSmartArray
{
    [TestClass]
    public class UnitTest1
    {
        const int SMART_ARRAY_SIZE = 5;

        // SmartArray should initialize with all zeros
        [TestMethod]
        public void ArrayStartWithAll_0s()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            //testSmartArray.SetAtIndex(2, 5);  //used to verify test is working
            int actual = 0;
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                actual = actual + testSmartArray.GetAtIndex(i);
            }
            // assert
            int expected = 0;
            Assert.AreEqual(expected, actual, 0.000001, "SmartArray not initilized to all zeros");
        }

        // SmartArray should allow setting the 0 location
        [TestMethod]
        public void SetLocation_0()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            testSmartArray.SetAtIndex(0, 5);
            // assert
            int actual = testSmartArray.GetAtIndex(0);
            int expected = 5;
            Assert.AreEqual(expected, actual, 0.000001, "Did not set SmartArray loc 0 correctly");
        }

      
        // Can successfully add a value  to each location in SmartArray
        [TestMethod]
        public void AddValueToEach()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);

            //fill each array position with zeros
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                testSmartArray.SetAtIndex(i,0);
            }

            //Test variable
            int actual = 0;

            //temp value for storage comparision
            int temp = 0;
            
            //add 1 to each location in array
            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            {
                actual = testSmartArray.GetAtIndex(i) + 1;
                testSmartArray.SetAtIndex(i, actual);
                temp = temp + testSmartArray.GetAtIndex(i);
                actual = (actual * 0) + temp;
            }

            //assert
            // SUM of Array should be 5.
            int expected = 5;
            Assert.AreEqual(expected, actual, 0.000001,"These values are not equal! AddValueToEach() test failed! Actual result was not 5");
        }


        // correctly returns True if a value is correctly found in the array
        // set a location to a value, use our SmartArray Find method, 
        //  you will need to use :
        //  Assert.IsTrue(expected, "Value not found in the array");
        [TestMethod]
        public void IsValueFound()
        {
            SmartArray testSmartArray = new SmartArray(SMART_ARRAY_SIZE);
            int actual = 25;
            testSmartArray.SetAtIndex(3, actual);
            bool expected = testSmartArray.Find(25);
            Assert.IsTrue(expected, "Value not found in the array");
        }

       
      
     
    }
}


