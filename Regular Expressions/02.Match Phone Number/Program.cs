using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}";

Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);

List<string> validNumbers = new List<string>();

foreach (Match match in matches)
{
    validNumbers.Add(match.Value);
}

Console.WriteLine(string.Join(", ", validNumbers));
