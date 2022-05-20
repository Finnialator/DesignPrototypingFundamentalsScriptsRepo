using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 3)
            {
                count++;
                Console.WriteLine("The loop has run " + count + " times.");
            }

            for(int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("The loop has run " + counter + " times.");
            }

            for( int counted = 3; counted >= 0; counted-= 1)
            {
                Console.WriteLine("The value of counted is now " + counted + ".");
                if (counted == 2)
                {
                    break;
                }
            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();
        }
    }
}
