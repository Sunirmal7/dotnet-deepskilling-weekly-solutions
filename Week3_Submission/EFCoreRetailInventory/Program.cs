using EFCoreRetailInventory.Context;
using EFCoreRetailInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("\n🚀 EF Core 8.0 - CRUD + LINQ DEMO 🚀");

            // ➕ INSERT
            var electronics = new Category { Name = "Electronics" };
            var phone = new Product
            {
                Name = "Smartphone",
                Price = 25000,
                StockQuantity = 50,
                Category = electronics
            };
            context.Products.Add(phone);
            context.SaveChanges();
            Console.WriteLine("✅ Inserted: Smartphone");

            // 📖 READ
            var products = context.Products.Include(p => p.Category).ToList();
            Console.WriteLine("\n📦 All Products:");
            foreach (var p in products)
                Console.WriteLine($"📌 {p.Name} | ₹{p.Price} | Category: {p.Category.Name}");

            // 🖊 UPDATE
            var productToUpdate = context.Products.FirstOrDefault(p => p.Name == "Smartphone");
            if (productToUpdate != null)
            {
                productToUpdate.Price = 22999;
                context.SaveChanges();
                Console.WriteLine("✏️ Updated: Smartphone Price -> ₹22999");
            }

            // ❌ DELETE
            var productToDelete = context.Products.FirstOrDefault(p => p.Name == "Smartphone");
            if (productToDelete != null)
            {
                context.Products.Remove(productToDelete);
                context.SaveChanges();
                Console.WriteLine("🗑️ Deleted: Smartphone");
            }

            Console.WriteLine("\n✅ CRUD Operations Completed");

            // 🧠 LINQ QUERY - Lab 7
            Console.WriteLine("\n📊 LINQ: Products costing more than ₹1000");

            var expensiveProducts = context.Products
                .Where(p => p.Price > 1000)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var p in expensiveProducts)
            {
                Console.WriteLine($"💸 {p.Name} - ₹{p.Price}");
            }
        }
    }
}
