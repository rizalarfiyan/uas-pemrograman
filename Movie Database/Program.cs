public class Program
{
    public static void Main(string[] args)
    {
        // Deklarasi class MovieDatabase
        MovieDatabase database = new MovieDatabase();

        // Deklarasi List dari ActionMovie
        List<ActionMovie> actionMovies = new List<ActionMovie>()
        {
            new ActionMovie
            {
                Title = "Sri Asih",
                ReleaseYear = 2023,
                Director = "Upi Avianto"
            },
            new ActionMovie
            {
                Title = "Gundala",
                ReleaseYear = 2019,
                Director = "Joko Anwar"
            },
            new ActionMovie
            {
                Title = "Mencuri Raden Saleh",
                ReleaseYear = 2022,
                Director = "Angga Dwimas Sasongko"
            },
        };

        // Deklarasi List dari ComedyMovie
        List<ComedyMovie> comedyMovies = new List<ComedyMovie>()
        {
            new ComedyMovie
            {
                Title = "My Stupid Boss",
                ReleaseYear = 2016,
                Actors = new string[] { "Reza Rahardian", "Alex Abbad", "Iskandar Zulkarnain", "Bunga Citra Lestari" }
            },
            new ComedyMovie
            {
                Title = "Insya Allah Sah",
                ReleaseYear = 2017,
                Actors = new string[] { "Titi Kamal", "Pandji Pragiwaksono", "Tanta Ginting", "Deddy Mizwar" }
            },
        };

        // Deklarasi dari AnimatedMovie
        AnimatedMovie animatedMovie = new AnimatedMovie()
        {
            Title = "Battle of Surabaya",
            ReleaseYear = 2015,
            AnimationStudio = "MSV Pictures"
        };

        // Deklarasi dari DocumentaryMovie
        DocumentaryMovie documentaryMovie = new DocumentaryMovie()
        {
            Title = "Islands of Faith",
            ReleaseYear = 2020,
            Subjects = new string[] { "Alam", "Budaya", "Semesta", "Indonesia" }
        };

        // Tambahkan data film ke dalam MovieDatabase
        database.AddMovies(actionMovies);
        database.AddMovies(comedyMovies);
        database.AddMovie(animatedMovie);
        database.AddMovie(documentaryMovie);

        // tampilkan semua film
        Console.WriteLine("Daftar Semua Film:");
        database.PrintAllMovies();
    }
}