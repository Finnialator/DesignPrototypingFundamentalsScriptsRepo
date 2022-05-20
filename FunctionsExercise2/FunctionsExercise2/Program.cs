using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercise2
{
    internal class Program
    {
        static int score;

        static void Main()
        {
            Start();
        }

        static void Start()
        {
            score = 100;
            Console.WriteLine("The current score is " + score);
            PrintScore(25);
            PrintScore(75);
            PrintScore(150);
            Console.ReadLine();
        }

        static int AddToScore(int add)
        {
            score += add;
            return score;
        }

        static void PrintScore(int add)
        {
            Console.WriteLine("You scored! The score is now " + AddToScore(add));
        }
    }
}
