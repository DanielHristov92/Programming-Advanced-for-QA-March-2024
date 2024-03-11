int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!synonyms.ContainsKey(word))
    {
        synonyms[word] = new List<string>();
    }

    synonyms[word].Add(synonym);
}

foreach (var pair in synonyms)
{
    string word = pair.Key;
    string synonymsList = string.Join(", ", pair.Value);
    Console.WriteLine($"{word} - {synonymsList}");
}