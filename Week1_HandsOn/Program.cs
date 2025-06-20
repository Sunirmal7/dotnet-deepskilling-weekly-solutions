using System;
using System.Collections.Generic;
using System.Linq;
using Week1Exercises.DesignPatterns;
using Week1Exercises.Algorithms;

namespace Week1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(Singleton.Instance.GetMessage());

     
            var product = ProductFactory.CreateProduct("a");
            Console.WriteLine(product.GetDetails());

            var products = new List<Product>
            {
                new() { Id = 1, Name = "Laptop", Price = 800 },
                new() { Id = 2, Name = "Phone", Price = 400 },
                new() { Id = 3, Name = "Headphones", Price = 150 }
            };

            var results = ECommerceSearch.Search(products, "lap");
            Console.WriteLine("\nSearch Results:");
            results.ForEach(p => Console.WriteLine($"{p.Id}: {p.Name} - ${p.Price}"));

      
            var priceHistory = new List<decimal> { 100, 102, 104, 106, 108 };
            var forecast = FinancialForecast.MovingAverageForecast(priceHistory, 3, 5);
            Console.WriteLine("\nForecast:");
            forecast.ForEach(p => Console.WriteLine($"Predicted Price: {p}"));
        }
    }
}
