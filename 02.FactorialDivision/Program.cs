namespace _02.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int firstNumberFactorial = Factorial(firstNumber);
            int secondNumberFactorial = Factorial(secondNumber);

            
            double result = (double)firstNumberFactorial / secondNumberFactorial;
            Console.WriteLine(result);
        }

        static int Factorial(int number)
        {
            int result = 1;
            for (int i = number; i >= 2; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
