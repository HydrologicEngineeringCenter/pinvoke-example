using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using csharp_pinvoke;

namespace csharp_pinvoke_tests
{
    [TestClass]
    public class BasicPinvokeTests
    {
        [TestMethod]
        public void TestIntReturn()
        {
            Assert.AreEqual(AddWrapper.add(1, 2), 3);
        }

        [TestMethod]
        public void TestStringReturn()
        {
            Assert.AreEqual(StringWrapper.getHelloString(), "Hello");
        }

        [TestMethod]
        public void TestStringInputAndReturn()
        {
            int[] arr = new int[10];
            ArraysWrapper.fillArrayWithVals(arr, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i], i);
            }
        }
    }
}
