using System;

// Clase para trabajar con un círculo
public class Circulo
{
    // Aquí guardo el radio del círculo
    private double radio;

    // Constructor: cuando creo un círculo pongo su radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Esta función calcula el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Esta función calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para trabajar con un rectángulo
public class Rectangulo
{
    // Aquí guardo el ancho y el alto del rectángulo
    private double ancho;
    private double alto;

    // Constructor: cuando creo un rectángulo le doy ancho y alto
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // Esta función calcula el área del rectángulo
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // Esta función calcula el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}

public class Program
{
    public static void Main()
    {
        // Creo un círculo y le pongo radio 5
        Circulo c = new Circulo(5);

        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        // Creo un rectángulo de 4 x 6
        Rectangulo r = new Rectangulo(4, 6);

        Console.WriteLine("\n=== RECTÁNGULO ===");
        Console.WriteLine("Área: " + r.CalcularArea());
        Console.WriteLine("Perímetro: " + r.CalcularPerimetro());
    }
}
