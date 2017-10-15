using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaupjcFirst;

namespace UnitTestRaupjc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IIntegerList listOfIntegers = new IntegerList();
            
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); //[2 ,3 ,4]
            Assert.AreEqual(3, listOfIntegers.Count); // 3
            Assert.IsFalse(listOfIntegers.Remove(100));
            Assert.ThrowsException<IndexOutOfRangeException>(() => listOfIntegers.RemoveAt(5));
            listOfIntegers.Clear() ; // []
            Assert.AreEqual(0, listOfIntegers.Count);
        }
    }
}
