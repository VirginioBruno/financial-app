namespace myTestApp
{
    public class ExpenseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime? LastUpdate { get; set; } = null;
        public string Category { get; set; }
        public string PaymentForm { get; set; }
    }
}
