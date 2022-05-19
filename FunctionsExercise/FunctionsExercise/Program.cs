using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExercise
{
    class Game
    {
        public int score = 0;

        public void Start()
        {
            Console.WriteLine("Score is: " + score);
            PrintScore(5);
            PrintScore(100);
            PrintScore(250);
            Console.ReadLine();
        }

        public int AddToScore(int add)
        {
            score += add;
            return score;
        }

        public void PrintScore(int add)
        {
            Console.WriteLine("You scored! Score is now: " + AddToScore(add));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.score = 100;
            game.Start();
        }
    }
}
