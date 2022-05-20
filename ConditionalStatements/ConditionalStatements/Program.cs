using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main()
        {
            int playerHealth = 100;
            int monsterDamage = 110;
            playerHealth -= monsterDamage;

            if (playerHealth == 0)
            {
                playerHealth = 0;
            }

            Console.WriteLine("A monster attacked you and did " + monsterDamage + " damage. You have " + playerHealth + " health left.");


            if (playerHealth == 0)
            {
                Console.WriteLine("You died. Game over.");
            }
            else if (monsterDamage > 100)
            {
                Console.WriteLine("The monster is terrifyingly strong.");
            }
            else if (monsterDamage > 0)
            {
                Console.WriteLine("The monster prepares to attack you again!");
            }

            Console.ReadKey();
        }
    }
}
