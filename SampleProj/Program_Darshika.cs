using System;
namespace SampleProj
{
    class Program_Darshika
    {
        public static void Main(String[] args)
        {
            int a;
            int b;
            
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("The addition of a and b = " + sum);
            Console.ReadLine();
        }
    }
}
    