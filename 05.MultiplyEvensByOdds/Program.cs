using System;

namespace MultiplyEvenAndOddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumEven = GetSumOfEvenDigits(number);
            int sumOdd = GetSumOfOddDigits(number);

            
            return sumEven * sumOdd;
        }

         
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
             
            number = Math.Abs(number);

             
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0) 
                {
                    sumEven += digit;
                }
                number /= 10;  
            }

            return sumEven;
        }

         
        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            
            number = Math.Abs(number);

             
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)  
                {
                    sumOdd += digit;
                }
                number /= 10; 
            }

            return sumOdd;
        }
    }
}
