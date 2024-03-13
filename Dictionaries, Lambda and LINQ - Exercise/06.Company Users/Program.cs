Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string companyName = data[0];
    string employeeId = data[1];

    if (!companies.ContainsKey(companyName))
    {
        companies[companyName] = new HashSet<string>();
    }

    companies[companyName].Add(employeeId);
}

foreach (var kvp in companies)
{
    Console.WriteLine(kvp.Key);
    foreach (var employeeId in kvp.Value)
    {
        Console.WriteLine($"-- {employeeId}");
    }
}