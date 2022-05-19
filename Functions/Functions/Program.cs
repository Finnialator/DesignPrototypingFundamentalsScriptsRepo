using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        // Variables
        static int playerHealth = 100;
        static int monsterDamage = 30;

        static void MonsterEncounter()
        {
            Console.WriteLine("A vicious monster appears!");
            Console.ReadKey();
        }
        
        static void MonsterAttacks(int damage)
        {
            int combo = 0;
            combo += 1;
            playerHealth -= damage;
            Console.WriteLine("The monster attacks you for " + damage + " points of damage. You have " + playerHealth + " health left.");
            Console.ReadKey();
        }

        static void Start()
        {
            Console.WriteLine("My game has begun!");
            Console.ReadKey();
            MonsterEncounter();
            MonsterAttacks(monsterDamage * 2);
            MonsterAttacks(monsterDamage);
            MonsterAttacks(monsterDamage * 3);

            monsterDamage = 5;
        }

        static void Main() 
        {
            Start();
        }
    }
}
