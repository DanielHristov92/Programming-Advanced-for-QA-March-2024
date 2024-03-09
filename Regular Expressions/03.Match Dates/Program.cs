using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(?'day'\d{2})(?'del'[\/\.\-])(?'month'[A-Z][a-z]{2})\'del'(?'year'\d{4})";

Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(input);

List<string> validDates = new List<string>();

foreach (Match match in matches)
{
    string day = match.Groups["day"].Value;
    string month = match.Groups["month"].Value;
    string year = match.Groups["year"].Value;

    validDates.Add($"Day: {day}, Month: {month}, Year: {year}");
}

Console.WriteLine(string.Join(Environment.NewLine, validDates));