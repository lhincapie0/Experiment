using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
   public class CombSort
    {

        public int getNextGap(int gap)
        {
            // Shrink gap by Shrink factor 
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }
        public int[] sort(int[] arr)
        {
            int n = arr.Length;

            int gap = n;

            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;

                        swapped = true;
                    }
                }


            }
            return arr;
        }
    }
}
