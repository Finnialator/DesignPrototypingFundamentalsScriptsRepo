using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main()
        {
            float playerHealth;
            bool inCombat = false;
            float monsterHealth = 100;
            playerHealth = 100;
            monsterHealth = 50;
            string battleStartText = "Battle has commenced";
            string playerHealthText = "Player has " + playerHealth + " Health";
            string monsterHealthText = "Monster has " + monsterHealth + " Health";

            Console.WriteLine(battleStartText);
            Console.WriteLine(playerHealthText);
            Console.WriteLine(monsterHealthText);
            Console.ReadKey();
        }
    }
}
