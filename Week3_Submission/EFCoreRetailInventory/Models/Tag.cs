using System.Collections.Generic;

namespace EFCoreRetailInventory.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
