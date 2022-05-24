using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            int highest = -100;
            if(num1 > highest)
            {
                highest = num1;
            }
            if(num2 > highest)
            {
                highest = num2;
            }
            if(num3 > highest)
            {
                highest = num3;
            }
            Console.WriteLine(highest + " is the largest variable");

            /*if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the largest variable.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is the largest variable.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " is the largest variable.");
            }*/
            Console.ReadLine();
        }
    }
}
