using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Experiment
{
    public class Control
    {

        public static int[] inverso;
        public static int[] seudo_aleatorio;
        public static int[] seudo_aleatorio_inverso;

        //Modifi
        private static int size = 800000;
        static void Main(string[] args)
        {
            ArrayGenerator ag = new ArrayGenerator();

            MergeSort merge = new MergeSort();
            CombSort comb = new CombSort();
            HeapSort heap = new HeapSort();
            StreamWriter sw = new StreamWriter("C: /Users/lauhi/source/repos/lhincapie0/Experiment/Experiment/Experiment/Arreglos/Resultados/" +size+"/int/"+size+ ".txt");

            inverso = ag.getInverseArray(size);
            seudo_aleatorio = ag.getRandomArray(size);
            seudo_aleatorio_inverso = ag.getInverseRandom(size);


            //MergeSort
            DateTime tiempo1 = DateTime.Now;
            merge.sort(inverso, 0, inverso.Length - 1);
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");
           sw.Write("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

            tiempo1 = DateTime.Now;
            merge.sort(seudo_aleatorio, 0, seudo_aleatorio.Length - 1);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

              sw.Write("Seudo Aleatorio MergeSort = " + total.TotalMilliseconds + "\n");

            tiempo1 = DateTime.Now;
            merge.sort(seudo_aleatorio_inverso, 0, seudo_aleatorio_inverso.Length - 1);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

              sw.Write("Seudo Aleatorio Inverso MergeSort = " + total.TotalMilliseconds + "\n");

            //CombSort
            inverso = ag.getInverseArray(size);
            seudo_aleatorio = ag.getRandomArray(size);
            seudo_aleatorio_inverso = ag.getInverseRandom(size);

            tiempo1 = DateTime.Now;
            comb.sort(inverso);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

             sw.Write("Inverso CombSort = " + total.TotalMilliseconds + "\n");

            comb = new CombSort();
            tiempo1 = DateTime.Now;
            comb.sort(seudo_aleatorio);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

               sw.Write("Seudo Aleatorio CombSort = " + total.TotalMilliseconds + "\n");

            comb = new CombSort();
            tiempo1 = DateTime.Now;
            comb.sort(seudo_aleatorio_inverso);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

                sw.Write("Seudo Aleatorio Inverso CombSort = " + total.TotalMilliseconds + "\n");

            //HeapSort
            inverso = ag.getInverseArray(size);
            seudo_aleatorio = ag.getRandomArray(size);
            seudo_aleatorio_inverso = ag.getInverseRandom(size);

            tiempo1 = DateTime.Now;
            heap.sort(inverso);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

             sw.Write("Inverso HeapSort = " + total.TotalMilliseconds + "\n");

            tiempo1 = DateTime.Now;
            heap.sort(seudo_aleatorio);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

            sw.Write("Seudo Aleatorio HeapSort = " + total.TotalMilliseconds + "\n");

            tiempo1 = DateTime.Now;
            heap.sort(seudo_aleatorio_inverso);
            tiempo2 = DateTime.Now;
            total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks); Console.WriteLine("Inverso MergeSort = " + total.TotalMilliseconds + "\n");

            Console.ReadKey(true);
             sw.Write("Seudo Aleatorio Inverso HeapSort = " + total.TotalMilliseconds + "\n");
        }
    }
}
