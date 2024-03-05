using System.Text;

string input = Console.ReadLine();

StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder others = new StringBuilder();

foreach (char c in input)
{
    if (char.IsDigit(c))
    {
        digits.Append(c);
    }
    else if (char.IsLetter(c))
    {
        letters.Append(c);
    }
    else
    {
        others.Append(c);
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);