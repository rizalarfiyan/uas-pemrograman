public class Person
{
    private string name;
    private string nim;
    private int age;

    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetNim(string nim)
    {
        this.nim = nim;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Nama : " + this.name);
        Console.WriteLine("NIM  : " + this.nim);
        Console.WriteLine("Umur : " + this.age);
    }
}
