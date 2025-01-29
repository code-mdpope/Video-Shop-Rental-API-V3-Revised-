namespace VideoShopRentalAPIv3.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Customer? Customer { get; set; }
        public ICollection<RentalDetails>? RentalDetails { get; set; }

        public string RentalDateFormatted => RentalDate.ToString("M/d/yyyy");
        public string ReturnDateFormatted => ReturnDate.ToString("M/d/yyyy");
    }
}
