using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    internal class Program
    {
        static void Main()
        {         
            string greet ="Hello, user!";
            int playerScore = 0;
            string displayScore = "Your score currently is" + playerScore + ".";

            Console.WriteLine(greet);
            Console.WriteLine(displayScore);
            Console.ReadKey();

            string greeting = "Hello, user! The game's start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);

            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();
        }
    }
}
