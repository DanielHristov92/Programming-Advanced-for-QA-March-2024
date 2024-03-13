string resource = Console.ReadLine();

Dictionary<string, int> resources = new Dictionary<string, int>();

while(resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(resource))
    {
        resources[resource] += quantity;
    }
else
    {
        resources.Add(resource, quantity);
    }
    resource = Console.ReadLine();
}

foreach (var pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}