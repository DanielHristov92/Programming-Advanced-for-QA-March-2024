int numberOfCommands = int.Parse(Console.ReadLine());

var usersWithPlates = new Dictionary<string, string>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] commandParams = Console.ReadLine().Split();
    string command = commandParams[0];
    string user = commandParams[1];

    if (command == "register")
    {
        string plate = commandParams[2];

        if (!usersWithPlates.ContainsKey(user))
        {
            usersWithPlates.Add(user, plate);
            Console.WriteLine($"{user} registered {plate} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {usersWithPlates[user]}");
        }
    }
    else if (command == "unregister")
    {
        if (usersWithPlates.ContainsKey(user))
        {
            usersWithPlates.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
    }
}

foreach (var pair in usersWithPlates)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}