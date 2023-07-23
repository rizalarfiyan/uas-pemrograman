// Kelas abstrak (kontrak) untuk Movie
public abstract class Movie
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    // method abstraksi untuk menampilkan detail
    // bisa juga dikatakan sebagai polimorfisme
    public abstract void PrintDetails();
}