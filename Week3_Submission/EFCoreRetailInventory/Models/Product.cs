using System.ComponentModel.DataAnnotations;

namespace EFCoreRetailInventory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
