using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    public class ArrayGenerator
    {

        public int[] getInverseArray(int size)
        {

            int[] array = new int[size];

            int j = 0;
            for (int i = size; i > 0; i--)
            {
                array[j] = i;
                j++;
            }
          

            return array;
        }


        public int[] getRandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i<array.Length; i++)
            {
                int a = random.Next(0, 1000000000); ;
                array[i] = a;

            }
            return array;
        }


        public int[] getInverseRandom(int size)
        {
            int[] array = getRandomArray(size);
            Array.Sort(array);
            Random random = new Random();
            for (int i = size - 1; i > size / 2; i--)
            {
                array[i] = random.Next(0, 1000000000);
            }
            return array;
        }
    }
}
