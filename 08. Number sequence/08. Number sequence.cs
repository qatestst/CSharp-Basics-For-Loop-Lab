namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;
            int maxNumber = int.MinValue;



            for (int i = 1; i <= counter; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (counter == 1)
                {
                    smallestNumber = a;
                    maxNumber = a;
                }

                if (a <= smallestNumber)
                {
                    smallestNumber = a;
                }
                else if (a > maxNumber)
                {
                    maxNumber = a;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine($"Max number: {maxNumber}");
                Console.WriteLine($"Min number: {smallestNumber}");
            }


        }
    }
}