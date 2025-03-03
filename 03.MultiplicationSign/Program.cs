namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (IsZero(a, b, c))
            {
                Console.WriteLine("zero");
            }
            else if (GetNegativeNumbersCount(a, b, c) % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        
        static int GetNegativeNumbersCount(int a, int b, int c)
        {
            int negativeNumbers = 0;
            if (a < 0)
            {
                negativeNumbers++;
            }
            if (b < 0)
            {
                negativeNumbers++;
            }
            if (c < 0)
            {
                negativeNumbers++;
            }
            return negativeNumbers;
        }

       
        static bool IsZero(int a, int b, int c)
        {
            return a == 0 || b == 0 || c == 0;
        }
    }
}
