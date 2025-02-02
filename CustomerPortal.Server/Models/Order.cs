namespace CustomerPortal.Server.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime Created { get; set; }
        public int Quantity { get; set; }
    }
}
