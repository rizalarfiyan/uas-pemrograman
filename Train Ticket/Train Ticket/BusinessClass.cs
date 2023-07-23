class BusinessClass : Train
{
    public BusinessClass(string name, decimal price) : base(name, price)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine($"| Nama     : {this.WithPad(this.Name)} |");
        Console.WriteLine($"| Harga    : {this.WithPad(this.CurrencyIndonesia(this.Price))} |");
        Console.WriteLine($"| Kelas    : {this.WithPad("Bisnis")} |");
        Console.WriteLine("+----------------------------------------------+");
    }
}
