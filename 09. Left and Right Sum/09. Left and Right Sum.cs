namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sumA = 0;
            int sumB = 0;
            int diff = 0;

            for (int i = 1; i <= counter; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sumA += a;
            }

            for (int i = 1; i <= counter; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sumB += b;
            }

            if (sumA == sumB)
            { Console.WriteLine($"Yes, sum = {sumA}"); }
            else if (sumA != sumB)
            { Console.WriteLine($"No, diff = {Math.Abs(sumA - sumB)}"); }

        }
    }
}