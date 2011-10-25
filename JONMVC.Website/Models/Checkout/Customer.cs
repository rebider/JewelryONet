namespace JONMVC.Website.Models.Checkout
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}