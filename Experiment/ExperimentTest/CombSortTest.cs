using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Experiment;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ExperimentTest
{


    [TestClass]
    public class CombSortTest
    {
        public CombSort combSort;
        public int[] arr;
        public int[] arr2;


        public void setUp1()
        {
            combSort = new CombSort();
            arr = new int[] { 30, 12, 22, 10, 26, 35, 8, 18, 40, 15 };
            arr2 = new int[] { 8, 10, 12, 15, 18, 22, 26, 30, 35, 40 };
        }

        public void setUp2()
        {
            arr = new int[100];

            combSort = new CombSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp3()
        {
            arr = new int[160000];

            combSort = new CombSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp4()
        {
            arr = new int[800000];

            combSort = new CombSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }

        public void setUp5()
        {
            arr = new int[2000000];

            combSort = new CombSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
        }


        public void setUp6()
        {
            combSort = new CombSort();
            arr = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, };
            arr2 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        }


        public void setUp7()
        {
            arr = new int[800000];

            combSort = new CombSort();
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        [TestMethod]
        public void combSortRandom1Test()
        {
            setUp1();
            arr = combSort.sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void combSortRandom2Test()
        {
            setUp2();
            arr = combSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void combSortRandom3Test()
        {
            setUp3();
            arr = combSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }


        [TestMethod]
        public void combSortRandom4Test()
        {
            setUp4();
            arr = combSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void combSortRandom5Test()
        {
            setUp4();
            arr = combSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }

        [TestMethod]
        public void combSortInverse1Test()
        {
            setUp1();
            arr = combSort.sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Assert.AreEqual(arr[i], arr2[i]);
            }
        }

        [TestMethod]
        public void combSortInverse2Test()
        {
            setUp2();
            arr = combSort.sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                Assert.IsTrue(arr[i - 1] <= arr[i]);
            }
        }
    }
}
