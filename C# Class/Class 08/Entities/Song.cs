using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Song
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Length { get; set; }

        public Song(string songTitle, Genre songGenre, int songLength)
        {
            Title = songTitle;
            Genre = songGenre;
            Length = songLength;
        }
    }
}
