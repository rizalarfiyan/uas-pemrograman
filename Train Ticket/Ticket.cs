class Ticket
{
    public string Name { get; set; }
    public string NIK { get; set; }
    public string PhoneNumber { get; set; }
    public string VaccineCardNumber { get; set; }
    public string Address { get; set; }
    public Train SelectedTrain { get; set; }

    public void DisplayTicketInfo()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine($"| Nama         : {this.WithPad(this.Name)} |");
        Console.WriteLine($"| NIK          : {this.WithPad(this.NIK)} |");
        Console.WriteLine($"| Telepon      : {this.WithPad(this.PhoneNumber)} |");
        Console.WriteLine($"| Kartu Vaksin : {this.WithPad(this.VaccineCardNumber)} |");
        Console.WriteLine($"| Alamat       : {this.WithPad(this.Address)} |");
        Console.WriteLine("+----------------------------------------------+");
        SelectedTrain.DisplayInfo();
    }

    public string WithPad(string str, int pad = 29)
    {
        return str.PadRight(pad);
    }
}