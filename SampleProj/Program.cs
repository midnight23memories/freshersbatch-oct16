using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine("Multiplication result: " + result);
        }
    }
}
