class Program
{
    static void Main()
    {
        App app = new App();
        app.Run();

        SubApp subApp = new SubApp();
        subApp.Run();
    }
}