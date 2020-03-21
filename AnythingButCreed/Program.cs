using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();

            var song = new Song("exo", "growl");
            var song2 = new Song("blackpink", "fire");
            var song3 = new Song("2ne1", "fire");
            var song4 = new Song("creed", "bad boyz");
            var song5 = new Song("creed", "bad song");
            var song6 = new Song("creed", "bad songz");
            var song7 = new Song("creed", "bad boyz 2");
            var song8 = new Song("snsd", "into the world");
            var song9 = new Song("bts", "fire");
            var song10 = new Song("dbsk", "mirotic");
            var song11 = new Song("dbsk", "wrong number");
            var song12 = new Song("creed", "bad love");

            List<Song> allSongs = new List<Song> { song, song2, song3, song4, song5, song6, song7, song8, song9, song10, song11, song12};

            var noCreed = allSongs.Where(singleSong => singleSong.Artist != "creed");
            goodSongs.AddRange(noCreed);

            foreach (var goodSong in goodSongs)
            {
                // for each goodSong get the value of artist and name
                Console.WriteLine($"{goodSong.Artist}: {goodSong.Name}");
            }

        }
    }
}
