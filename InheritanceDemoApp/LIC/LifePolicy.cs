    namespace LIC;

public    class LifePolicy : Policy
{
    public double SumAssured { get; set; }
    public int Age { get; set; }

    public override  double CalculatePremium()
    {
        // Life insurance premium calculation
        double premium = SumAssured * 0.01;
        if (Age > 50)
            premium = premium * 1.20;
        return premium;
    }

    //  wait 
}