string firstString = Console.ReadLine();

string secondString = Console.ReadLine();

while (secondString.Contains(firstString))
{
    int wordIndex = secondString.IndexOf(firstString);
    string before = secondString.Substring(0, wordIndex);
    string after = secondString.Substring(wordIndex + firstString.Length);  

    secondString = before + after;
}

Console.WriteLine(secondString);