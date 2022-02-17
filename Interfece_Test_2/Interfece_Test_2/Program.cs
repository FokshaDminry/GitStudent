using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfece_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> product = new List<string>() { "Bread", "Milk", "Oil", "Tomatto", "Banana", "Coca-Cola", "Meat", "Oion" };
            List<string> managers = new List<string>() { "Ernest Hemingway", "Erich Remarque", "Friedrich Nietzsthe", "Franz Kafka", "Immanuel Kant", "Anthny Burgess", "Gabriel Garcia Marquez", "Hermann Hesse" };
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < 300; i++)
            {
                sales.Add(new Sale
                {
                    NameManager = managers.Skip(random.Next(managers.Count())).First(),
                    NameProduct = product.Skip(random.Next(managers.Count())).First(),
                    Price = random.Next(0, 100),
                    Date = DateTime.Parse($"2021-01-01").AddSeconds(random.Next(60 * 60 * 24 * 365))
                });
            }
            foreach (var item in sales.Select(s => s).Where(s => s.Date.Month >= 1 && s.Date.Month < 2))
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in sales.Select(s => s).Where(s => s.NameManager == "Friedrich Nietzsthe"))
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in sales.GroupBy(s => s.NameManager))
            {
                Console.WriteLine(item.Key + " Sale: " + item.Count());
            }
            int MaxSale = sales.Max(s => s.Price);
            int SumSale = sales.Sum(s => s.Price);
            Console.WriteLine($"Max Sale: {MaxSale}");
            Console.WriteLine($"Sum Sale: {SumSale}");
        }
    }
}
