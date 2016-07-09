/*
Write a class Sale holding the following data: town, product, price, quantity. Read a list of sales and calculate and print the total sales by town as shown in the output. Order alphabetically the towns in the output.

Examples
Input	                        Output	                Comments
5                               Plovdiv -> 96.80        Plovdiv -> 1.10 * 88 = 96.80
Sofia beer 1.20 160             Sofia -> 533.20         Sofia -> 1.20 * 160 + 0.40 * 853 = 533.20
Varna chocolate 2.35 86         Varna -> 266.98         Varna -> 2.35 * 86 + 0.86 * 75.44 = 266.98
Sofia coffee 0.40 853
Varna apple 0.86 75.44
Plovdiv beer 1.10 88	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int numberOfSales = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> profit = new Dictionary<string, decimal>();

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < numberOfSales; i++)
            {
                string[] saleArguments = Console.ReadLine().Split().ToArray();

                Sale sale = new Sale()
                {
                    Town = saleArguments[0],
                    Product = saleArguments[1],
                    Price = decimal.Parse(saleArguments[2]),
                    Quantity = double.Parse(saleArguments[3])
                };

                sales.Add(sale);
            }

            List<string> towns = sales.Select(e => e.Town).OrderBy(e => e).Distinct().ToList();

            foreach (var town in towns)
            {
                Console.WriteLine("{0} -> {1:F2}", town, sales
                    .Where(e => e.Town == town)
                    .Select(e => e.Price * (decimal)e.Quantity)
                    .Sum());
            }
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }


    }
}
