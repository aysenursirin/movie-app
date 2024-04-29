namespace MovieApp.Models
{
    class MovieCategoryModel
    {
        public Movie.Movie? Movie { get; set; }
        public IEnumerable<Movie.Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}