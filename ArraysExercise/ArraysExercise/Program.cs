using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    internal class Program
    {
        //1.
        /*int[] numbers = new int[10] { 0, 0, 1, 0, 0, 1, 0, 0, 1, 1 };
        int[] matrix = new int[5] { 1, 2, 3, 4, 5, 6, 7 };
        double[] radii = new double[10] { 3.2, 4.7 };
        int[] table = new int[7] { 2, , , 27, , 45, 39 };
        char[] codes = { 'A', 'X', '1', '2', 's' };
        int[] blanks;
        int[] collection = new int[-20];
        int[] hours = new int[3] 8, 12, 16;*/


        static void Main(string[] args)
        {
            //2.
            /*int[] values = { 2, 6, 10, 14 };
            Console.WriteLine(values[2]);
            Console.WriteLine(++values[0]);
            Console.WriteLine(++values[0]);
            int x = 2;
            Console.WriteLine(values[++x]);
            Console.WriteLine(values[4]);
            Console.ReadLine();*/


            //3.
            /*int[] data = new int[10];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = data.Length - i;
                Console.WriteLine(data[i]);
            }
            Console.ReadLine();*/


            //4.
            /*int[] userNumbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter a number; ");
                string tempNumber = Console.ReadLine();
                userNumbers[i] = Convert.ToInt32(tempNumber);
            }
            for (int i = 3;i > -1; i--)
            {
                Console.WriteLine(userNumbers[i]);
            }
            Console.ReadLine();*/


            //5.
            /*int[] values = new int[5];
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Please enter a number; ");
                string input = Console.ReadLine();
                values[i] = Convert.ToInt32(input);
            }
            int smallestValue = values[0];
            int largestValue = values[0];
            for (int i = 0;i < values.Length; i++)
            {
                if (values[i] < smallestValue)
                {
                    smallestValue = values[i];
                }
                if (values[i] > largestValue)
                {
                    largestValue = values[i];
                }
            }
            Console.WriteLine("The smallest value is: " + smallestValue);
            Console.WriteLine("The largest value is: " + largestValue);
            Console.ReadLine();*/


            //6.
            
        }
    }
}
