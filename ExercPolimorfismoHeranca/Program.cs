using System;
using System.Globalization;
using System.Collections.Generic;
using ExercPolimorfismoHeranca.Entities;

namespace ExercPolimorfismoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char usedOrImported = char.Parse(Console.ReadLine());

                Console.Write("Name :");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (usedOrImported == 'i')
                {
                    Console.Write("Customs free: ");
                    double custums = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, custums));
                }
                else if (usedOrImported == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufacturedDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }                                                     
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
            }           
            Console.ReadLine();
        }
    }
}
