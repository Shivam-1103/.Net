
namespace PaymentProcessing
{

    // Concrete Class : A class that can be instantiated and used to create objects.
    public class UpiPayment : Payment
    {
        private decimal TaxRate = 0.02m; // Example tax rate of 2%

        public UpiPayment(decimal amount, string currency) : base(amount, currency)
        {
        }

       public override void ProcessPayment()
        {
            // Implementation for processing UPI payment
            decimal totalAmount = Amount + (Amount * TaxRate);
            Console.WriteLine($"Processing UPI payment of {totalAmount} {Currency} (including tax)");
        }
    }
}