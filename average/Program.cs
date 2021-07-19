using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many numbers do you have");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int average;
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("enter" + i + "number");
                int number=Convert.ToInt32(Console.ReadLine());
                sum += number;            
            }
            average = sum / n;
            Console.WriteLine(average);
        }
    }
}
