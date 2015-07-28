using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Lists;
using System.Collections;

namespace DataStructuresUnitTests
{
    [TestClass]
    public class StackUnitTests
    {
        //[TestMethod]
        //public void TestStackOld()
        //{
        //    int top;
        //    Stack<int> stack = new Stack<int>();

        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);
        //    stack.Push(4);
        //    stack.Push(5);
        //    stack.Push(6);

        //    stack.ToHumanReadable();

        //    var array = stack.ToArray();
        //    Assert.AreEqual(array.Length, stack.Count, "Wrong size!");

        //    top = stack.Pop();
        //    Assert.AreEqual(top, 6);

        //    stack.Pop();
        //    stack.Pop();

        //    var array2 = stack.ToArray();
        //    Assert.AreEqual(array2.Length, stack.Count, "Wrong size!");
        //}

        [TestMethod]
        public void TestStackStdContr()
        {
            Stack<int> stack = new Stack<int>();
            Assert.AreEqual(stack.Count, 0);
            Assert.IsTrue(stack.IsEmpty);
            CollectionAssert.AreEqual(stack.ToArray(), new int[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStackParamContrWrongParam()
        {
            Stack<int> stack = new Stack<int>(-2);
            Assert.AreEqual(stack.Count, 0);
            Assert.IsTrue(stack.IsEmpty);
            CollectionAssert.AreEqual(stack.ToArray(), new int[0]);
        }

        [TestMethod]
        public void TestStackParamContr()
        {
            Stack<int> stack = new Stack<int>(2);
            Assert.AreEqual(stack.Count, 0);
            Assert.IsTrue(stack.IsEmpty);
            CollectionAssert.AreEqual(stack.ToArray(), new int[0]);
        }

        [TestMethod]
        public void TestStackPushTopPop()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            Assert.AreEqual(stack.Count, 6);
            Assert.IsFalse(stack.IsEmpty);

            for (int i = 5; i >= 0; i--)
            {
                Assert.AreEqual(stack.Top, i);
                Assert.AreEqual(stack.Pop(), i);
            }

            Assert.AreEqual(stack.Count, 0);
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStackPopFromEmpty()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            for (int i = 5; i >= 0; i--)
            {
                Assert.AreEqual(stack.Pop(), i);
            }

            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestStackTopFromEmpty()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            for (int i = 5; i >= 0; i--)
            {
                Assert.AreEqual(stack.Pop(), i);
            }

            int top = stack.Top;
        }


        [TestMethod]
        public void TestStackEnumeratorTest()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            int j = 5;
            foreach (var item in stack)
            {
                Assert.AreEqual(item, j);
                j--;
            }
        }

        [TestMethod]
        public void TestStackIEnumeratorTest()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            int j = 5;
            foreach (var item in ((IEnumerable)stack))
            {
                Assert.AreEqual(item, j);
                j--;
            }
        }

        [TestMethod]
        public void TestStackToHumanReadable()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 5; i++)
                stack.Push(i);

            string str = "[0] => 5\r\n[1] => 4\r\n[2] => 3\r\n[3] => 2\r\n[4] => 1\r\n[5] => 0\r\n";
            Assert.AreEqual(str, stack.ToHumanReadable(), false);

        }
    }
}
