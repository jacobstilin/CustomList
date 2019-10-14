using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom_List;

namespace CustomListTest
{
    [TestClass]
    public class AddTests
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
    }




    [TestClass]
    public class RemoveTests
    { 
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
        public void Remove_RemoveRepeatedValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;

            // act
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(2);
            testList.Add(2);
            testList.Add(2);
            testList.Remove(1);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_CountDecrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;

            // act
            testList.Add(222);
            testList.Add(221);
            testList.Add(223);
            testList.Remove(222);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMoreThanCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 0;

            // act
            testList.Add(222);
            testList.Add(222);
            
            testList.Remove(222);
            testList.Remove(222);
            testList.Remove(222);
            int actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class ToStringTest
    {
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
    }




    [TestClass]
    public class PlusOverloadTests
    {
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
        public void PlusOverload_DifferentSizes()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 5;

            // act
            testList1.Add(221);
            testList1.Add(222);
            testList2.Add(221);
            testList2.Add(222);
            testList2.Add(223);
            testList3 = testList1 + testList2;
            int actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOverload_DoItAgain()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            CustomList<int> testList4 = new CustomList<int>();
            int expected = 6;

            // act
            testList1.Add(222);
            testList1.Add(222);
            testList2.Add(222);
            testList2.Add(222);
            testList3.Add(222);
            testList3.Add(222);
            testList4 = testList1 + testList2 + testList3;
            int actual = testList4.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }




    [TestClass]
    public class MinusOverloadTests
    {

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

        [TestMethod]
        public void MinusOverload_Works()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();
            string expected = "yamotha";

            // act
            testList1.Add("aow");
            testList1.Add("ya");
            testList1.Add("motha");

            testList2.Add("aow");
            testList2.Add("a");
            testList2.Add("wiseguyovaheya");
            testList3 = testList1 - testList2;

            string actual = testList3.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOverload_NoCommonValues()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            int expected = 3;

            // act
            testList1.Add(221);
            testList1.Add(222);
            testList1.Add(222);

            testList2.Add(454);
            testList2.Add(454);
            testList2.Add(454);
            testList3 = testList1 - testList2;
            int actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }




    [TestClass]
    public class ZipTests
    { 
        [TestMethod]
        public void Zip_CountRight()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 6;

            // act
            oddTestList.Add(1);
            oddTestList.Add(3);
            oddTestList.Add(5);

            evenTestList.Add(2);
            evenTestList.Add(4);
            evenTestList.Add(6);
            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_WorksNormally()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 3;
            // act
            oddTestList.Add(1);
            oddTestList.Add(3);
            oddTestList.Add(5);

            evenTestList.Add(2);
            evenTestList.Add(4);
            evenTestList.Add(6);
            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstListEmpty()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 3;

            // act
            evenTestList.Add(2);
            evenTestList.Add(4);
            evenTestList.Add(6);
            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecondListEmpty()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 3;

            // act
            oddTestList.Add(1);
            oddTestList.Add(3);
            oddTestList.Add(5);
            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_FirstListLargerThanSecond()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 8;

            // act
            oddTestList.Add(1);
            oddTestList.Add(3);
            oddTestList.Add(5);
            oddTestList.Add(7);
            oddTestList.Add(9);

            evenTestList.Add(2);
            evenTestList.Add(4);
            evenTestList.Add(6);
            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_SecondListLargerThanFirst()
        {
            // arrange
            CustomList<int> oddTestList = new CustomList<int>();
            CustomList<int> evenTestList = new CustomList<int>();
            CustomList<int> resultTestList = new CustomList<int>();
            int expected = 8;

            // act
            oddTestList.Add(1);
            oddTestList.Add(3);
            oddTestList.Add(5);

            evenTestList.Add(2);
            evenTestList.Add(4);
            evenTestList.Add(6);
            evenTestList.Add(8);
            evenTestList.Add(10);

            resultTestList = oddTestList.Zip(evenTestList);
            int actual = resultTestList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }

    // arrange

    // act

    // assert
}

