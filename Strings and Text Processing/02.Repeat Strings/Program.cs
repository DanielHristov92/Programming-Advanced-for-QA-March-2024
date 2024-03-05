string[] words = Console.ReadLine().Split().ToArray();

string result = "";

foreach (string word in words)
{
    for (int i = 0; i < word.Length; i++)
    {
        result += word;
    }
}

Console.WriteLine(result);