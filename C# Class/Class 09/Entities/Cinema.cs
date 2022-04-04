using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cinema
    {
        public string Name { get; set; }

        public List<string> Halls { get; set; }

        public List<Movie> Movies { get; set; }

        public Cinema(string name, List<string> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

    }
}
