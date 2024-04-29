using MovieApp.Models.Movie;

namespace MovieApp.Data
{
    public static class MovieRepository
    {

        private static List<Movie> _movies;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Id=1,
                Name="Charlie and the Chocolate Factory",
                Description="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eaque exercitationem voluptatum voluptates facilis ducimus error est sed atque nam! Fugiat voluptate asperiores ea rem id!",
                ShortDescription="Charlie and the Chocolate Factory", ImageUrl="1.jpg", CategoryId=1},
                new Movie(){Id=2,
                Name="Alice in Wonderland",
                Description="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eaque exercitationem voluptatum voluptates facilis ducimus error est sed atque nam! Fugiat voluptate asperiores ea rem id!",
                ShortDescription="Alice in Wonderland", ImageUrl="2.jpg", CategoryId=2},
                new Movie(){Id=3,
                Name="Chocolat",Description="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eaque exercitationem voluptatum voluptates facilis ducimus error est sed atque nam! Fugiat voluptate asperiores ea rem id!",
                ShortDescription="Chocolat", ImageUrl="3.jpg", CategoryId=2},
                new Movie(){Id=4,
                Name="Edward Scissorhands",Description="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eaque exercitationem voluptatum voluptates facilis ducimus error est sed atque nam! Fugiat voluptate asperiores ea rem id!",
                ShortDescription="Edward Scissorhands", ImageUrl="4.jpg", CategoryId=3},
                new Movie(){Id=5,
                Name="Don Juan de Marco", Description="Lorem ipsum, dolor sit amet consectetur adipisicing elit. Eaque exercitationem voluptatum voluptates facilis ducimus error est sed atque nam! Fugiat voluptate asperiores ea rem id!",
                ShortDescription="Don Juan de Marco", ImageUrl="5.jpg", CategoryId=3}
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie? GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}