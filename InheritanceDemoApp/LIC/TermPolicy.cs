namespace LIC;

public class TermPolicy :LifePolicy 
{
    public double CoverageAmount { get; set; }
    public int TermYears { get; set; }

    public TermPolicy(double amount, int years)
    {
        CoverageAmount=amount;
        TermYears=years;
        
    }

    //shadowing
    public new  double CalculatePremium()
    {
        // Term insurance premium calculation
        double premium = CoverageAmount * 0.015;
        if (TermYears > 20)
            premium = premium * 1.10;
        return premium;
    }
}