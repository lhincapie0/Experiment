using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Experiment;

namespace ExperimentTest
{
    [TestClass]
    public class HeapSortTest
    {
        public HeapSort heapSort;
        public int[] arr;
        public int[] arr2;


        public void setUp1()
        {
            heapSort = new HeapSort();
            arr = new int[] { 30, 12, 22, 10, 26, 35, 8, 18, 40, 15 };
            arr2 = new int[] { 8, 10, 12, 15, 18, 22, 26, 30, 35, 40 };
        }

        public void setUp2()
        {
            arr = new int[100];

            heapSort = new HeapSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp3()
        {
            arr = new int[160000];

            heapSort = new HeapSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp4()
        {
            arr = new int[800000];

            heapSort = new HeapSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        public void setUp5()
        {
            arr = new int[2000000];

            heapSort = new HeapSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp6()
        {
            heapSort = new HeapSort();
            arr = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, };
            arr2 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        }


        public void setUp7()
        {
            arr = new int[800000];

            heapSort = new HeapSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        [TestMethod]
        public void heapSortRandom1Test()
        {
            setUp1();
            arr = heapSort.sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void heapSortRandom2Test()
        {
            setUp2();
            arr = heapSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void heapSortRandom3Test()
        {
            setUp3();
            arr = heapSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }


        [TestMethod]
        public void heapSortRandom4Test()
        {
            setUp4();
            arr = heapSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void heapSortRandom5Test()
        {
            setUp4();
            arr = heapSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void heapSortInverse1Test()
        {
            setUp6();
            arr = heapSort.sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void heapSortInverse2Test()
        {
            setUp7();
            arr = heapSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }
    }
}

