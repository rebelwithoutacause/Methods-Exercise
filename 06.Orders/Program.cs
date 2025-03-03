using System;

namespace ProductOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

             
            double totalPrice = CalculateTotalPrice(product, quantity);
            Console.WriteLine($"{totalPrice:F2}");
        }

         
        static double CalculateTotalPrice(string product, int quantity)
        {
            double pricePerItem = 0;

            
            switch (product.ToLower())
            {
                case "coffee":
                    pricePerItem = 1.50;
                    break;
                case "water":
                    pricePerItem = 1.00;
                    break;
                case "coke":
                    pricePerItem = 1.40;
                    break;
                case "snacks":
                    pricePerItem = 2.00;
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    return 0;
            }

            
            return pricePerItem * quantity;
        }
    }
}
