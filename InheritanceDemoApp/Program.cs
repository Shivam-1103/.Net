
using PaymentProcessing;
using CRM;
using LIC;


namespace InheritanceDemoApp;
 
   public class Program
    {

        static void Main(string[] args)
        {
            
           //polymorphism : The ability of an object to take on many forms.
            
            //Inheritance
            Payment creditPayment = new CreditPayment(560.00m, "USD"); 
            Payment upiPayment = new UpiPayment(560.00m, "USD");
            Payment phonepePayment = new PhonepePayment(560.00m, "USD");    

            Payment[] payments = new Payment[] { creditPayment, upiPayment, phonepePayment }; 

            foreach (Payment payment in payments)
            {
                payment.ProcessPayment();  //polymorphic behavior : The method that gets executed is determined at runtime based on the object's actual type.
            }  
 

            // Composition
            //Customer customer = new Customer()("John Doe", "john.doe@example.com", new Date(2023, 1, 15));
           // Customer.DisplayCustomerInfo();



           Policy lifePolicy = new LifePolicy {
                PolicyId = 101,
                PolicyHolderName = "Rahul",
                SumAssured = 1000000,
                Age = 35
            };

         Policy healthPolicy = new HealthPolicy{
                PolicyId = 102,
                PolicyHolderName = "Priya",
                MedicalCoverage = 500000,
                Age = 45
            };

            Policy vehiclePolicy = new VehiclePolicy{ PolicyId = 103,
                PolicyHolderName = "Amit",
                VehicleValue = 800000,
                VehicleAge = 3
            };

        Policy[] policies = new Policy[] { lifePolicy, healthPolicy, vehiclePolicy };

        foreach (Policy policy in policies)
        {
            double premium = policy.CalculatePremium();
            Console.WriteLine($"Policy ID: {policy.PolicyId}, Holder: {policy.PolicyHolderName}, Premium: {premium}");
        }     


        policies[0].CalculatePremium(); // LifePolicy      

        LifePolicy lp=new TermPolicy(600000,25);
        lp.CalculatePremium();  //Parent class method

        TermPolicy tp=(TermPolicy)lp;
        tp.CalculatePremium();   //Child class method
        


    }   

}
 


//Two types of Classes:
//1. Abstract Class : A class that cannot be instantiated 
//                    and is meant to be inherited by other classes. 
//                    It can contain abstract methods that must be implemented by derived classes.

//2. Concrete Class : A class that can be instantiated and used to create objects. 
//                      It provides complete implementation of its methods and properties.