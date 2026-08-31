namespace LIC;
public class Policy
{
    
    public int PolicyId { get; set; }
    public string PolicyNumber { get; set; } = string.Empty;
    public int CustomerId { get; set; }
    public int? AgentId { get; set; }
    public int? EmployeeId { get; set; }
    public string PolicyType { get; set; } = string.Empty;
    public decimal PolicyAmount { get; set; }
    public bool IsRenewed { get; set; }

    //constructor overloading


    public Policy()
    {
        PolicyId = 9999;
        PolicyNumber = string.Empty;
        CustomerId = 99;
        AgentId = null;
        EmployeeId = null;
        PolicyType = string.Empty;
        PolicyAmount = 0;
        IsRenewed = false;
        
    }

     public Policy( int policyId, string policyNumber, int customerId, int? agentId,  int? employeeId, string policyType,
        decimal policyAmount,bool isRenewed)
    {
        PolicyId = policyId;
        PolicyNumber = policyNumber;
        CustomerId = customerId;
        AgentId = agentId;
        EmployeeId = employeeId;
        PolicyType = policyType;
        PolicyAmount = policyAmount;
        IsRenewed = isRenewed;
    }

    //Destructor
    ~Policy()
    {
        
    }
}