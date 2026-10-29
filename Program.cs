class Program
{
    static void Main(string [] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var coche1 = new Coche("Seat", "Ibiza");
        coche1.Acelerar(20);
        coche1.Acelerar(30);

        var coche2 = new Coche("BMW", "E36");
        coche2.Acelerar(120);
        coche2.Acelerar(30);
        coche2.Frenar(100);
    }
}