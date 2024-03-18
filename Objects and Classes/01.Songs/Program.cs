using System;
using System.Collections.Generic;
using System.Linq;

public class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public static List<Song> ParseSongs(int n)
    {
        List<Song> songs = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            string[] songData = Console.ReadLine().Split('_');
            Song song = new Song
            {
                TypeList = songData[0],
                Name = songData[1],
                Time = songData[2]
            };
            songs.Add(song);
        }
        return songs;
    }

    public static void PrintSongs(List<Song> songs, string filter)
    {
        if (filter == "all")
        {
            foreach (var song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (var song in songs.Where(s => s.TypeList == filter))
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = Song.ParseSongs(n);
        string filter = Console.ReadLine();

        Song.PrintSongs(songs, filter);
    }
}
