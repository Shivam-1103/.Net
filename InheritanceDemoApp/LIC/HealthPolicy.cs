namespace LIC;
public class HealthPolicy : Policy
{
    public double MedicalCoverage { get; set; }
    public int Age { get; set; }

    public override double CalculatePremium()
    {
        // Health insurance premium calculation
        double premium = MedicalCoverage * 0.05;

        if (Age > 50)
            premium = premium * 1.30;

        return premium;
    }
}