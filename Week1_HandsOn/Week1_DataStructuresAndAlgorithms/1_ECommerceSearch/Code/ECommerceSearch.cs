namespace Week1Exercises.Algorithms
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Price { get; set; }
    }

    public static class ECommerceSearch
    {
        public static List<Product> Search(List<Product> products, string keyword)
        {
            return products
                .Where(p => p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
