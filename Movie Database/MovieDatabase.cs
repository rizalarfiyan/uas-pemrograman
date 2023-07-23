// Kelas database film
public class MovieDatabase
{

    // Private variabel movies dengan tipe data List Movue
    private List<Movie> movies;

    public MovieDatabase()
    {
        movies = new List<Movie>();
    }

    // Salah satu penerapan enkapsulasi, movie tidak secara langsung di ubah,
    // tetapi harus menggunakan method addMovie
    public void AddMovie(Movie movie)
    {
        movies.Add(movie);
    }

    // Sama seperti method di atas, tetapi ini menggunakan tipe generic
    // yang bisa di ubah type datanya asalkan dia adalah turunan dari class Movie
    public void AddMovies<T>(List<T> movieList) where T : Movie
    {
        movies.AddRange(movieList);
    }

    // Menampilkan semua movie
    public void PrintAllMovies()
    {
        foreach (var movie in movies)
        {
            movie.PrintDetails();
        }
    }
}
