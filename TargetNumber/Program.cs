using System;

namespace TargetNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yout Target Number: ");
            int Target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many number do you want to pick?");
            int array = Convert.ToInt32(Console.ReadLine());
            int[] Identifier = new int[array];

            for (int i = 0; i < array; i++)
            {

                Console.WriteLine($"Enter Number {i + 1}:");
                Identifier[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < array; i++)
            {
                int Sum;
                for (int j = 1; j < array; j++)
                {
                    Sum = Identifier[i] + Identifier[j];
                    if (Sum == Target)
                    {
                        Console.WriteLine("first index: " + i);
                        Console.WriteLine("second index: " + j);
                        return;
                    }
                }
            }
            Console.WriteLine("There is no number like target number");

            Console.ReadLine();
        }
    }
}
