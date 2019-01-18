using System.Collections.Generic;

namespace foodstore.api.data.Models
{
    public class User
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<UserHouseholdLink> Households { get; set; }
    }
}