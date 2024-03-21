using System;

public class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main()
    {
        string[] articleData = Console.ReadLine().Split(", ");
        string title = articleData[0];
        string content = articleData[1];
        string author = articleData[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commandData = Console.ReadLine().Split(": ");
            string command = commandData[0];
            string argument = commandData[1];

            switch (command)
            {
                case "Edit":
                    article.Edit(argument);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(argument);
                    break;
                case "Rename":
                    article.Rename(argument);
                    break;
            }
        }

        Console.WriteLine(article);
    }
}