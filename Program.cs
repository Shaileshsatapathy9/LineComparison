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

            Console.WriteLine("Enter the value of p1: ");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of p2: ");
            int p2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of q1: ");
            int q1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of q2: ");
            int q2 = Convert.ToInt32(Console.ReadLine());

            Double Lengthoftheline1 = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Double Lengthoftheline2 = Math.Sqrt(Math.Pow((p2-p1), 2) + Math.Pow((q2-q1), 2));

            Console.WriteLine("Length of the line is 1 : " +Lengthoftheline1);
            Console.WriteLine("Length of the line is 2 : " +Lengthoftheline2);
            Console.WriteLine(Lengthoftheline1.Equals(Lengthoftheline2));
            Console.ReadLine();
        }
    }
}
