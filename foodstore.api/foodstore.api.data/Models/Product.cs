using System.Collections.Generic;

namespace foodstore.api.data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Barcode { get; set; }
        public double PortionSize { get; set; }
        public int NumberOfServings { get; set; }
        public int UserId { get; set; }
        public bool IsNewProduct { get; set; }

        public virtual ICollection<ProductNutrientLink> Nutrients { get; set; }
        public virtual ICollection<ProductCategoryLink> Categories { get; set; }
    }
}