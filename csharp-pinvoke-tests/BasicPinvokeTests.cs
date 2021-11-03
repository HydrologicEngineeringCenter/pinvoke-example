using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using csharp_pinvoke;
using System.Linq;

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
        public void TestArrayInputAndReturn()
        {
            int[] arr = new int[10];
            ArraysWrapper.fillArrayWithVals(arr, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i], i);
            }
        }

        [TestMethod]
        public void TestExampleClass()
        {
            ExampleClassWrapper ec = new ExampleClassWrapper(21, "example", new int[] { 1, 2, 3 });
            Assert.AreEqual(ec.Num, 21);
            Assert.AreEqual(ec.Word, "example");
            Assert.IsTrue(Enumerable.SequenceEqual(ec.Nums, new int[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void MemoryLeakTest()
        {
            for (int i = 0; i < 10000; i++)
            {
                int num = 21;
                string word = "example";
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                using (ExampleClassWrapper ec = new ExampleClassWrapper(num, word, arr))
                {
                    Assert.AreEqual(ec.Num, num);
                    Assert.AreEqual(ec.Word, word);
                    Assert.IsTrue(Enumerable.SequenceEqual(ec.Nums, arr));
                }
            }
        }
    }
}
