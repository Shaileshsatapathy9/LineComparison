using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double Lengthoftheline = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Console.WriteLine("Length of the line is : " +Lengthoftheline);
            Console.ReadLine();
        }
    }
}
