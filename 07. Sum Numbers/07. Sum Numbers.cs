﻿namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < +totalNumbers; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;

            }
            Console.WriteLine(sum);
        }
    }
}