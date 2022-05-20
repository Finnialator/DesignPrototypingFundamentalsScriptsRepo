using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int score = 0;

            while(count < 10)
            {
                count++;
                Console.WriteLine("This loop has run " + count + " times.");
            }

            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("This loop has run " + (counter + 1) + " times");
            }

            for(score = 0; score < 200; score = score + 20)
            {
                Console.WriteLine("The score is currently " + score + ".");
                if(score >= 100)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
