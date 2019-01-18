using System.Collections.Generic;

namespace foodstore.api.data.Models
{
    public class Nutrient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductNutrientLink> Products { get; set; }
    }
}