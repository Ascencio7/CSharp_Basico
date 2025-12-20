using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declarar la variable de manera implicitas
        var radio = 0d; // el 'd' indico que sea un double
        var resultado = 0d;

        // Solicitar el dato
        Console.Write("\nIngresa el valor del radio: ");
        radio = Convert.ToDouble(Console.ReadLine());

        resultado = Math.PI * Math.Pow(radio, 2);
        
        // Redondear el resultado
        resultado = Math.Round(resultado, 2);

        // Se muestra el resultado
        Console.WriteLine($"\nEl radio del circulo es: {resultado}");
        Console.WriteLine("Fin del programa.\n");
    }
}