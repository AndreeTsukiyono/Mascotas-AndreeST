using System;

class Mascota
{
    private string nombre;
    private int edad;
    private string tipo;

    public Mascota(string nombre, int edad, string tipo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.tipo = tipo;
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Tipo: " + tipo);
    }

    public int CalcularEdadHumana()
    {
        int edadHumana = edad * 7;
        return edadHumana;
    }

    public void SetEdad(int nuevaEdad)
    {
        edad = nuevaEdad;
    }

    public int GetEdad()
    {
        return edad;
    }
}

class Program
{
    // Método adicional para simular hacer jugo
    static void HacerJugo(string fruta)
    {
        Console.WriteLine("Haciendo jugo de " + fruta + "...");
        Console.WriteLine("¡Jugo de " + fruta + " listo!");
    }

    static void Main(string[] args)
    {
        // Primera mascota
        Mascota m1 = new Mascota("Firulais", 3, "perro");
        m1.MostrarInfo();
        Console.WriteLine("Edad humana: " + m1.CalcularEdadHumana());
        m1.SetEdad(5);
        Console.WriteLine("Nueva edad: " + m1.GetEdad());
        Console.WriteLine("Nueva edad humana: " + m1.CalcularEdadHumana());

        Console.WriteLine("-----------------------------");

        // Segunda mascota
        Mascota m2 = new Mascota("Michi", 2, "gato");
        m2.MostrarInfo();
        Console.WriteLine("Edad humana: " + m2.CalcularEdadHumana());
        m2.SetEdad(4);
        Console.WriteLine("Nueva edad: " + m2.GetEdad());
        Console.WriteLine("Nueva edad humana: " + m2.CalcularEdadHumana());

        Console.WriteLine("-----------------------------");

        // Llamada al método HacerJugo
        HacerJugo("naranja");
    }
}