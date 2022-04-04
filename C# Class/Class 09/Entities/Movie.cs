using Entities.Enums;
using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Movie
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Rating { get; set; }

        public int TicketPrice { get; set; }

        public Movie(string moveTitle, Genre movieGenre, int movieRating, int movieTicketPrice)
        {
            if (movieRating < 1 && movieRating > 5)
            {
                throw new InvalidRating($"The rating {movieRating} has to be between 1 and 5");
            }

            Title = moveTitle;
            Genre = movieGenre;
            Rating = movieRating;
            TicketPrice = 5 * movieRating;
        }
    }
}
