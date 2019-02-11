using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Experiment;

namespace ExperimentTest
{
    [TestClass]
    public class MergeSortTest
    {
        public MergeSort mergeSort;
        public int[] arr;
        public int[] arr2;


        public void setUp1()
        {
            mergeSort = new MergeSort();
            arr = new int[] { 30, 12, 22, 10, 26, 35, 8, 18, 40, 15 };
            arr2 = new int[] { 8, 10, 12, 15, 18, 22, 26, 30, 35, 40 };
        }

        public void setUp2()
        {
            arr = new int[100];

            mergeSort = new MergeSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp3()
        {
            arr = new int[160000];

            mergeSort = new MergeSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp4()
        {
            arr = new int[800000];

            mergeSort = new MergeSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        public void setUp5()
        {
            arr = new int[2000000];

            mergeSort = new MergeSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        public void setUp6()
        {
            mergeSort = new MergeSort();
            arr = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, };
            arr2 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        }


        public void setUp7()
        {
            arr = new int[800000];

            mergeSort = new MergeSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        [TestMethod]
        public void mergeSortRandom1Test()
        {
            setUp1();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void mergeSortRandom2Test()
        {
            setUp2();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void mergeSortRandom3Test()
        {
            setUp3();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }


        [TestMethod]
        public void mergeSortRandom4Test()
        {
            setUp4();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void mergeSortRandom5Test()
        {
            setUp4();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void mergeSortInverse1Test()
        {
            setUp6();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void mergeSortInverse2Test()
        {
            setUp7();
            arr = mergeSort.sort(arr, 0, arr.Length - 1);
            for (int i = 1; i < arr.Length; i++)
            {

                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }
    }
}
