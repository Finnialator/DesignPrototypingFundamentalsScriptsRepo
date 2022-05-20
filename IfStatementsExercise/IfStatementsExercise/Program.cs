using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsExercise
{
    internal class Program
    {
        static void Main()
        {
            bool playerAlive = true;
            int invulnerabilityTimer = 5;

            if (playerAlive)
            {
                Console.WriteLine("The player is still alive");
            }
            else
            {
                Console.WriteLine("The player is dead");
            }

            invulnerabilityTimer = invulnerabilityTimer - 2;

            if (invulnerabilityTimer > 0)
            {
                Console.WriteLine("You are invulnerable to damage");

                 if (playerAlive == true)
                {
                    invulnerabilityTimer -= 1;
                }
            }
            else if (invulnerabilityTimer == 0)
            {
                Console.WriteLine("You are vulnerable to damage");
            }
            else if (invulnerabilityTimer < 0)
            {
                invulnerabilityTimer = 0;
            }
            Console.ReadLine();
        }
    }
}
