using System.Globalization;

abstract class Train
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Train(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayInfo();

    public string CurrencyIndonesia(decimal price)
    {
        return price.ToString("C", new CultureInfo("id-ID"));
    }

    public string WithPad(string str, int pad = 33)
    {
        return str.PadRight(pad);
    }
}
