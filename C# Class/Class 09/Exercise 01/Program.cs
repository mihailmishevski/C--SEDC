using Entities;
using Entities.Enums;
using Entities.Exceptions;
using System;
using System.Collections.Generic;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Cinema cineplexx = new Cinema("Cineplexx", new List<string>() { "Hall 7", "Hall 3", "Hall 5", }, 
                                                            new List<Movie>() 
                                                           { new Movie("Batman", Genre.Action, 7, 50)});
            }
            catch (InvalidRating exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
