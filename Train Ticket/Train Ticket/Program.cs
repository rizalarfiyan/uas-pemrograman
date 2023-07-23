class Program
{
    static void Main()
    {
        List<Train> trains = new List<Train>()
        {
            new EconomyClass("Lodaya (C)", 250000),
            new EconomyClass("Muatiara Selatan (C)", 300000),
            new BusinessClass("Malabar (B)", 350000),
            new ExecutiveClass("Turangga (A)", 460000),
            new ExecutiveClass("Argo Wilis (A)", 570000),
        };

        Actions action = new Actions();
        action.AddTrains(trains);
        action.Run();
    }
}