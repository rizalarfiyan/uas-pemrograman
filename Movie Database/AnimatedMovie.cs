// Kelas turunan Movie untuk AnimatedMovie (Inheritance)
public class AnimatedMovie : Movie
{
    public string AnimationStudio { get; set; }

    // menimpa method PrintDetails dari class parent
    public override void PrintDetails()
    {
        Console.WriteLine($"Film Animasi: {Title} ({ReleaseYear}) - Studio Animasi: {AnimationStudio}");
    }
}
