using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entities
{
    public class Person
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person(string personId, string personFirstName, string personLastName, int personAge, Genre personFavMusic, List<Song> personFavSongs)
        {
            Id = personId;
            FirstName = personFirstName;
            LastName = personLastName;
            Age = personAge;
            FavoriteMusicType = personFavMusic;
            FavoriteSongs = personFavSongs;
        }

        public void GetFavSongs()
        {
            /*if(FavoriteSongs.Count > 0)
            {
                for(int i = 0; i < FavoriteSongs.Count; i++)
                {
                    Console.WriteLine(FavoriteSongs[i].Title);
                }
            }
            
            if(FavoriteSongs.Count <= 0)
            {
                Console.WriteLine("Dont have any of these favorite songs!");
            }
*/
            List<string> hipHopSongs = FavoriteSongs.Where(song => song.Genre == Genre.Hip_Hop)
                                     .Select(song => song.Title)
                                     .ToList();
            List<string> longerThenTwenty = FavoriteSongs.Where(song => song.Length > 20)
                                     .Select(song => song.Title)
                                     .ToList();
            
            foreach (string song in hipHopSongs)
            {
                Console.WriteLine($"This song is a hiphop song {song}");
            }

            foreach (string song in longerThenTwenty)
            {
                Console.WriteLine($"This song is longer then 20 seconds {song}");
            }

            Console.WriteLine(hipHopSongs[0]);

        }
    }
}
