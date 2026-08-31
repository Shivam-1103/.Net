namespace LIC;

public  abstract  class Policy
{
    public int PolicyId { get; set; }
    public string PolicyHolderName { get; set; }

    // Common contract
    public  abstract  double CalculatePremium();
    
}