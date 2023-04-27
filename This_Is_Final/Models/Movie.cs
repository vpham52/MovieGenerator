namespace This_Is_Final.Models
{
    public class Movie
    {
        public Movie()
        {


        }

        public string Rank { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Rating { get; set; }
        public string Id { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Trailer { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writers { get; set; }
        public string Imdbid { get; set; }


        public string APIResponse { get; set; }

        public List<Movie> MoviesList { get; set; } = new List<Movie>();
    }
}
