class Actions
{
    private List<Ticket> tickets = new List<Ticket>();

    private List<Train> trains = new List<Train>();

    public void AddTrains(List<Train> trains)
    {
        foreach (Train train in trains)
        {
            this.trains.Add(train);
        }
    }

    private void DisplayAppName()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|                                              |");
        Console.WriteLine("|            Train Ticketing System            |");
        Console.WriteLine("|                 KAI Indonesia                |");
        Console.WriteLine("|             Yogyakarta - Bandung             |");
        Console.WriteLine("|         by M Rizal Arfiyan (22.11.5227)      |");
        Console.WriteLine("|                                              |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayThankYou()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("| Terimakasih telah menggunakan aplikasi kami! |");
        Console.WriteLine("|                 KAI Indonesia                |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayInvalidMenu()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|             Pilihan tidak valid!             |");
        Console.WriteLine("|              Silahkan coba lagi              |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayNoOrder()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|         Belum ada tiket yang dibeli.         |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayOrder()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|           Tiket yang telah dibeli:           |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplaySuccessOrder()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|           Tiket berhasil dipesan!            |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayInvalidTrain()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|          Pilihan kereta tidak valid!         |");
        Console.WriteLine("+----------------------------------------------+");
    }

    private void DisplayPriceList()
    {
        Console.WriteLine("+----------------------------------------------+");
        Console.WriteLine("|             Daftar Harga Kereta:             |");
        Console.WriteLine("+----------------------------------------------+");
    }

    public void Run()
    {
        this.DisplayAppName();
        int choice;
        do
        {
            Console.WriteLine(" Menu yang tersedia:");
            Console.WriteLine(" 1. Daftar harga tiket kereta");
            Console.WriteLine(" 2. Pesan tiket kereta");
            Console.WriteLine(" 3. Histori transaksi");
            Console.WriteLine(" 4. Keluar");
            Console.Write(" Pilihan: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    this.DisplayAppName();
                    DisplayTrainPrices();
                    break;
                case 2:
                    Console.Clear();
                    this.DisplayAppName();
                    OrderTicket();
                    break;
                case 3:
                    Console.Clear();
                    this.DisplayAppName();
                    CheckTickets();
                    break;
                case 4:
                    Console.Clear();
                    this.DisplayAppName();
                    this.DisplayThankYou();
                    break;
                default:
                    Console.Clear();
                    this.DisplayAppName();
                    this.DisplayInvalidMenu();
                    break;
            }

            Console.WriteLine();
        } while (choice != 4);
    }

    private void DisplayTrainPrices()
    {
        this.DisplayPriceList();
        int idx = 1;
        foreach (Train train in trains)
        {
            Console.WriteLine($"=====================> {idx} <======================");
            train.DisplayInfo();
            idx++;
        }
    }

    private void OrderTicket()
    {
        Ticket ticket = new Ticket();

        Console.Write(" Masukkan nama: ");
        ticket.Name = Console.ReadLine();
        Console.Write(" Masukkan NIK: ");
        ticket.NIK = Console.ReadLine();
        Console.Write(" Masukkan nomor telepon: ");
        ticket.PhoneNumber = Console.ReadLine();
        Console.Write(" Masukkan nomor kartu vaksin: ");
        ticket.VaccineCardNumber = Console.ReadLine();
        Console.Write(" Masukkan alamat: ");
        ticket.Address = Console.ReadLine();

        Console.WriteLine(" Pilih Kelas Kereta:");
        DisplayTrainPrices();
        Console.Write(" Pilihan: ");
        int trainIndex = Convert.ToInt32(Console.ReadLine());

        if (trainIndex >= 1 && trainIndex < trains.Count + 1)
        {
            ticket.SelectedTrain = trains[trainIndex-1];
            tickets.Add(ticket);
            this.DisplaySuccessOrder();
            return;
        }

        this.DisplayInvalidTrain();
    }

    private void CheckTickets()
    {
        if (tickets.Count == 0)
        {
            this.DisplayNoOrder();
            return;
        }

        this.DisplayOrder();

        int idx = 1;
        foreach (Ticket ticket in tickets)
        {
            Console.WriteLine($"=====================> {idx} <======================");
            ticket.DisplayTicketInfo();
            idx++;
        }
    }
}