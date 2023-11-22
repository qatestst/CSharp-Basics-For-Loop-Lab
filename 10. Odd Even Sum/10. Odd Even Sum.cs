namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= counter; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += inputNumber;
                }
                else
                {
                    sumOdd += inputNumber;
                }

            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sumEven - sumOdd));
            }
        }
    }
}