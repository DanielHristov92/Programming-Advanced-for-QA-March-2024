string input = Console.ReadLine();
string[] words = input.Split(' ');

Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

foreach (string word in words)
{
    if (wordCounts.ContainsKey(word.ToLower()))
    {
        wordCounts[word.ToLower()]++;
    }
    else
    {
        wordCounts[word.ToLower()] = 1;
    }
}

List<string> result = new List<string>();

foreach (var pair in wordCounts)
{
    if (pair.Value % 2 != 0)
    {
        result.Add(pair.Key);
    }
}

Console.WriteLine(string.Join(" ", result));