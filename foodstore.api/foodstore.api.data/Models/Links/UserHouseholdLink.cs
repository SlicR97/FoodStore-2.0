namespace foodstore.api.data.Models
{
    public class UserHouseholdLink
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int HouseholdId { get; set; }
        public Household Household { get; set; }
    }
}