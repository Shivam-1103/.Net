
List<Policy> policies = new List<Policy>
{
    new Policy
    {
        PolicyId = 1,
        PolicyNumber = "POL1001",
        CustomerId = 101,
        CustomerName = "Rahul",
        PolicyType = "Life",
        Status = "Active",
        Premium = 15000,
        SumAssured = 500000
    },

    new Policy
    {
        PolicyId = 2,
        PolicyNumber = "POL1002",
        CustomerId = 102,
        CustomerName = "Priya",
        PolicyType = "Health",
        Status = "Active",
        Premium = 25000,
        SumAssured = 800000
    },

    new Policy
    {
        PolicyId = 3,
        PolicyNumber = "POL1003",
        CustomerId = 101,
        CustomerName = "Rahul",
        PolicyType = "Vehicle",
        Status = "Expired",
        Premium = 12000,
        SumAssured = 300000
    },

    new Policy
    {
        PolicyId = 4,
        PolicyNumber = "POL1004",
        CustomerId = 103,
        CustomerName = "Amit",
        PolicyType = "Life",
        Status = "Active",
        Premium = 50000,
        SumAssured = 2000000
    },

    new Policy
    {
        PolicyId = 5,
        PolicyNumber = "POL1005",
        CustomerId = 104,
        CustomerName = "Sneha",
        PolicyType = "Health",
        Status = "Pending",
        Premium = 18000,
        SumAssured = 600000
    },

    new Policy
    {
        PolicyId = 6,
        PolicyNumber = "POL1006",
        CustomerId = 105,
        CustomerName = "Vijay",
        PolicyType = "Travel",
        Status = "Active",
        Premium = 8000,
        SumAssured = 150000
    },

    new Policy
    {
        PolicyId = 7,
        PolicyNumber = "POL1007",
        CustomerId = 106,
        CustomerName = "Neha",
        PolicyType = "Life",
        Status = "Active",
        Premium = 35000,
        SumAssured = 1500000
    },

    new Policy
    {
        PolicyId = 8,
        PolicyNumber = "POL1008",
        CustomerId = 102,
        CustomerName = "Priya",
        PolicyType = "Health",
        Status = "Expired",
        Premium = 11000,
        SumAssured = 400000
    }
};

// var results = policies
//     .Where(p => p.Premium > 10000)
//     .Where(p => p.Status == "Active")
//     .ToList();
 
// foreach (var p in results)
// {
//     Console.WriteLine($"{p.PolicyNumber} - ₹{p.Premium} ");
// };
// var policyNumbers = policies
//     .Where(p => p.Premium > 10000)
//     .Select(p => p.PolicyNumber)
//     .ToList();

// foreach(var p in policyNumbers)
//     {
//         Console.WriteLine(p);
//     };
Var
