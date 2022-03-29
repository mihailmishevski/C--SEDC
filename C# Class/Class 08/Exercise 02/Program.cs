using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Exercise_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>()
            {
                { new Person("0", "Mihail", "Mishevski", 28, Genre.Techno, new List<Song>()
                {
                    new Song("something", Genre.Hip_Hop, 50),
                    new Song("anything", Genre.Hip_Hop, 20),
                    new Song("nothing", Genre.Hip_Hop, 10)
                })}
            };
            person[0].GetFavSongs();
        }
    }
}
