namespace assetsbackend.Domain.Entity;
public class Booking
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required int Quantity { get; set; }
    }
