using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            

            // act
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityLastIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 222;

            // act
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(222);
            int actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_ItemGoesToProperIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 222;

            // act
            testList.Add(12);
            testList.Add(12);
            testList.Add(12);
            testList.Add(222);
            int actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsThatGrowCapacityMultipleTimes()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 9;


            // act
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            testList.Add(234);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemovesAnElement()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 7;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Remove(2);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_RemovesDesiredElement()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Remove(2);
            int actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ToStringWorks()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "aowyamotha";

            // act
            testList.Add("aow");
            testList.Add("ya");
            testList.Add("motha");
            string actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_CountIsRight()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 4;

            // act
            testList1.Add(222);
            testList1.Add(222);
            testList2.Add(222);
            testList2.Add(222);
            testList3 = testList1 + testList2;
            int actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_CheckIndex()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 221;

            // act
            testList1.Add(221);
            testList1.Add(222);
            testList2.Add(221);
            testList2.Add(222);
            testList3 = testList1 + testList2;
            int actual = testList3[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_CountRight()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 2;

            // act
            testList1.Add(221);
            testList1.Add(222);
            testList1.Add(222);

            testList2.Add(221);
            testList2.Add(454);
            testList2.Add(454);
            testList3 = testList1 - testList2;

            int actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }

    // arrange

    // act

    // assert
}

