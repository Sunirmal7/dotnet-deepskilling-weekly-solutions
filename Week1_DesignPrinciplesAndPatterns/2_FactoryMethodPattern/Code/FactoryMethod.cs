namespace Week1Exercises.DesignPatterns
{
    public interface IProduct
    {
        string GetDetails();
    }

    public class ProductA : IProduct
    {
        public string GetDetails() => "Product A Created";
    }

    public class ProductB : IProduct
    {
        public string GetDetails() => "Product B Created";
    }

    public static class ProductFactory
    {
        public static IProduct CreateProduct(string type)
        {
            return type.ToLower() switch
            {
                "a" => new ProductA(),
                "b" => new ProductB(),
                _ => throw new ArgumentException("Invalid product type"),
            };
        }
    }
}
