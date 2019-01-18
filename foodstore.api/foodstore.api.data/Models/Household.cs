using System.Collections.Generic;

namespace foodstore.api.data.Models
{
    public class Household
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserHouseholdLink> Users { get; set; }
    }
}