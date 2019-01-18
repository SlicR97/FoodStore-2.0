using System.Collections.Generic;

namespace foodstore.api.data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProductCategoryLink> Products { get; set; }
    }
}