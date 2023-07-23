// Kelas turunan dari Movie untuk DocumentaryMovie (Inheritance)
public class DocumentaryMovie : Movie
{
    public string[] Subjects { get; set; }

    // menimpa method PrintDetails dari class parent
    public override void PrintDetails()
    {
        Console.WriteLine($"Film Dokumenter: {Title} ({ReleaseYear}) - Subjek: {string.Join(", ", Subjects)}");
    }
}