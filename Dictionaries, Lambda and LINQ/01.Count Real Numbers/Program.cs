List<double> numbers = Console.ReadLine()
                       .Split()
                       .Select(double.Parse)
                       .ToList();

SortedDictionary<double, int> counter = new SortedDictionary<double, int>();

foreach (var number in numbers)
{
    if (counter.ContainsKey(number))
    {
        counter[number]++;
    }
    else
    {
        counter.Add(number, 1);
    }
}

foreach (KeyValuePair<double, int> element in counter)
{
    Console.WriteLine($"{element.Key} -> {element.Value}");
}