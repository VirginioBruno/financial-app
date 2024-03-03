namespace myTestApp
{
    public class Expense
    {
        public Guid? Id { get; set; } = null;
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }
        public string PaymentForm { get; set; }
    }
}
