namespace VideoShopRentalAPIv3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
