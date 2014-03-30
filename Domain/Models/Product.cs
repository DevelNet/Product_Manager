namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public double? PurchaseCost { get; set; }

        public double? Price { get; set; }

        public int? Quantity { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}