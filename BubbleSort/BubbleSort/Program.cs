using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToBeSorted = new int[]
            {
                14,65,63,1,54,
                89,84,9,98,57,
                71,18,21,84,69,
                28,11,83,13,42,
                64,58,78,82,13,
                9,96,14,39,89,
                40,32,51,85,48,
                40,23,15,94,93,
                35,81,1,9,43,
                39,15,17,97,52
            };
            Console.WriteLine("Unsorted");
            PrintArray(arrayToBeSorted);
            BubbleSort(arrayToBeSorted);
            Console.WriteLine("\nSorted");
            PrintArray(arrayToBeSorted);
            Console.ReadLine();
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0},\t", array[i]);
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void BubbleSort(int[] array)
        {
            if(array.Length <= 1)
            {
                return;
            }
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }
    }
}
