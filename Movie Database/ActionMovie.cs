// Kelas turunan dari Movie untuk ActionMovie (Inheritance)
public class ActionMovie : Movie
{
    public string Director { get; set; }

    // menimpa method PrintDetails dari class parent
    public override void PrintDetails()
    {
        Console.WriteLine($"Film Aksi: {Title} ({ReleaseYear}) - Disutradarai oleh {Director}");
    }
}