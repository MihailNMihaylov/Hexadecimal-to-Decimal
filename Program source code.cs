using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace floating_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hexdecimal: ");
            string hexValue = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your number in decimal is: {0} ", Convert.ToInt32(hexValue, 16));
            Console.WriteLine();

        }
    }
}

