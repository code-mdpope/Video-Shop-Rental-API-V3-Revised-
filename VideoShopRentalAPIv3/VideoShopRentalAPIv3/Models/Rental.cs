namespace VideoShopRentalAPIv3.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string RentalDate { get; set; }
        public string ReturnDate { get; set; }

        public Customer Customer { get; set; }
        public ICollection<RentalDetails> RentalDetails { get; set; }
    }
}
