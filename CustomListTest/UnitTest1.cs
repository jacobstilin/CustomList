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





    }


}

