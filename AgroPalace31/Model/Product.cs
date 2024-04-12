using AgroPalace31.Enum;

namespace AgroPalace31.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
    }
}
