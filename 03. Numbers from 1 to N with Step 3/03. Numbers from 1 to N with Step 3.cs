﻿namespace _03._Numbers_from_1_to_N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i += 3)
            {
                Console.WriteLine(i);

            }
        }
    }
}