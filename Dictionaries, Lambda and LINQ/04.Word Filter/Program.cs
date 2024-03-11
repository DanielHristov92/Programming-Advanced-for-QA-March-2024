string[] words = Console.ReadLine().Split();

foreach (string word in words)
{
    if (word.Length % 2 == 0)
    {
        Console.WriteLine(word);
    }
}