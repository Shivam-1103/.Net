namespace LIC;
public class VehiclePolicy : Policy
{
    public double VehicleValue { get; set; }
    public int VehicleAge { get; set; }

    public override double CalculatePremium()
    {
        // Vehicle insurance premium calculation
        double premium = VehicleValue * 0.02;

        if (VehicleAge > 5)
            premium = premium * 1.15;

        return premium;
    }
}