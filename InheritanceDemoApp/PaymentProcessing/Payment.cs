namespace PaymentProcessing
{

    // Abstract Class : A class that cannot be instantiated
    public abstract class Payment
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Payment(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public abstract void ProcessPayment();  
        // Abstract method that must be implemented by derived classes
        
    }
}