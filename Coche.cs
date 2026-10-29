public class Coche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidad { get; set; }

    public Coche(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidad = 0;
    }

    public void Acelerar(int incremento)
    {
        Velocidad += incremento;
        Console.WriteLine($"El {Marca} {Modelo} aceleró. Velocidad actual: {Velocidad} km/h. Velocidad que aceleró: {incremento} km/h");
    }

    public void Frenar(int decremento)
    {
        Velocidad -= decremento;

        if (Velocidad < 0)
        {
            Velocidad = 0;
        }
        Console.WriteLine($"El {Marca} {Modelo} frenó. Velocidad actual: {Velocidad} km/h. Velocidad que deceleró: {decremento} km/h");
    }
}