class Program
{
    static void Main(string[] args)
    {
        Fruit apple = new Apple();
        Fruit banana = new Banana();

        Console.WriteLine("Fruit 1:");
        Console.WriteLine("Name: " + apple.Name);
        apple.DisplayColor();

        Console.WriteLine();

        Console.WriteLine("Fruit 2:");
        Console.WriteLine("Name: " + banana.Name);
        banana.DisplayColor();
    }
}