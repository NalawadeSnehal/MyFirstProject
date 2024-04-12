using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class GreatestNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 >= num2 && num1 >=num3)
            {
                Console.WriteLine($"num1 is greatest {num1}");

            }
            else if(num2 >= num1 && num2 >=num3)
            {
                Console.WriteLine($"num2 is greatest {num2}");
            }
            else
            {
                Console.WriteLine($"num3 is greatest {num3}");
            }

        }

    }
}
