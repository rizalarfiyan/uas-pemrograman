// Kelas turunan dari Movie untuk ComedyMovie (Inheritance)
public class ComedyMovie : Movie
{
    public string[] Actors { get; set; }

    // menimpa method PrintDetails dari class parent
    public override void PrintDetails()
    {
        Console.WriteLine($"Film Komedi: {Title} ({ReleaseYear}) - Pemeran: {string.Join(", ", Actors)}");
    }
}
