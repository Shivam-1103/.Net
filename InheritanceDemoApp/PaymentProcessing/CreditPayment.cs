namespace PaymentProcessing
{

    // Concrete Class : A class that can be instantiated and used to create objects.

    //Is a relationship : Inheritance : The CreditPayment class is a subclass of the Payment class, inheriting its properties and methods.
    public class CreditPayment : Payment
    {

        private decimal TaxRate = 0.05m; // Example tax rate of 5%

        public CreditPayment(decimal amount, string currency) : base(amount, currency)
        {
        }

        //Parent class : base class : Suer class
        //Child class : derived class : Sub class


        //Method overriding is a feature in object-oriented programming 
       // that allows a subclass (Child) to provide a specific implementation of a method 
       // that is already defined in its superclass. 
       // 
       //When a method in a subclass has the same name, return type, and parameters 
       // as a method in its superclass, the subclass's method overrides the superclass's method. This allows for dynamic polymorphism, where the method that gets executed is determined at runtime based on the object's actual type.
        public override void ProcessPayment()
        {
            // Implementation for processing credit payment
            decimal totalAmount = Amount + (Amount * TaxRate);
            Console.WriteLine($"Processing credit payment of {totalAmount} {Currency} (including tax)");    
 
        }
    }
}

//please wait

