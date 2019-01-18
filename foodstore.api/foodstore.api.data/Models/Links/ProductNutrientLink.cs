namespace foodstore.api.data.Models
{
    public class ProductNutrientLink
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }

        public int NutrientId { get; set; }
        public Nutrient Nutrient { get; set; }

        public double Quantity { get; set; }
    }
}