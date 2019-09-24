using System.Collections.Generic;

namespace BookMyShow.Models
{
    public class Movie
    {
        public List<Movie> Movies { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
    }
}