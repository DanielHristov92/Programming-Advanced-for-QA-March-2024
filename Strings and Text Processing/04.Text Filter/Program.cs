string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

string text = Console.ReadLine();

foreach (string bannedWord in bannedWords)
{
    string asterisks = new string('*', bannedWord.Length);

    text = text.Replace(bannedWord, asterisks);
}

Console.WriteLine(text);