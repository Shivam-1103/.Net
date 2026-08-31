namespace PaymentProcessing
{
    public class PhonepePayment : Payment
    {
        
        public decimal TaxRate = 0.03m; // Example tax rate of 3%
        public PhonepePayment(decimal amount, string currency) : base(amount, currency)
        {
        }

        public override void ProcessPayment()
        {
            // Implementation for processing phonepe payment
            decimal totalAmount = Amount + (Amount * TaxRate);
            Console.WriteLine($"Processing phonepe payment of {totalAmount} {Currency} (including tax)");
        }
    }
}