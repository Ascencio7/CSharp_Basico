using System;
using System.Drawing;

public class Program
{
    public static void Main(String[] args)
    {
        // Juego de BlackJack

        // Declaro las variables
        int totalJugador = 0;
        int totalDealer = 0;
        int num = 0;
        int platziCoins = 0;
        string message = "";
        string controlOtraCarta = "";
        string switchControl = "menu";

        System.Random random = new System.Random();

        //Blackjack, Juntar 21 pidiendo, en casa de pasarte de 21 pierdes.
        //cartas o en caso de tener menos
        //de 21 igual tener mayor puntuación que el dealer

        while (true)
        {

            Console.WriteLine("\nWelcome al P l a t z i n o");
            Console.WriteLine("¿Cuántos PlatziCoins deseas? \n" +
                               "Ingresa un número entero \n" +
                               "Recuerda que necesitas 1 por ronda");
            platziCoins = int.Parse(Console.ReadLine());

            for (int i = 0; i < platziCoins; i++)
            {
                totalJugador = 0;
                totalDealer = 0;

                switch (switchControl)
                {
                    case "menu":

                        Console.Write("\nEscriba ‘21’ para jugar al 21: ");
                        switchControl = Console.ReadLine();
                        i = i - 1; //para que me vaya descontando las platzicoins
                        break;
                    case "21":
                        do
                        {
                            num = random.Next(1, 12);
                            totalJugador = totalJugador + num;
                            Console.WriteLine("\nToma tu carta, jugador,");
                            Console.WriteLine($"\nTe salió el número: {num} ");
                            Console.WriteLine("\n¿Deseas otra carta ?");
                            controlOtraCarta = Console.ReadLine();

                        } while (controlOtraCarta == "Si" ||
                                 controlOtraCarta == "si" ||
                                 controlOtraCarta == "yes");

                        totalDealer = random.Next(14, 23);
                        Console.WriteLine($"\nEl dealer tiene {totalDealer}");

                        if (totalJugador > totalDealer && totalJugador < 22)
                        {
                            message = "\nVenciste al dealer, felicidades";
                            switchControl = "menu";
                        }
                        else if (totalJugador >= 22)
                        {
                            message = "\nPerdiste vs el dealer, te pasaste de 21";
                            switchControl = "menu";
                        }
                        else if (totalJugador <= totalDealer)
                        {
                            message = "\nPerdiste vs el dealer, lo siento";
                            switchControl = "menu";
                        }
                        else
                        {
                            message = "\nCondición no válida";
                        }
                        Console.WriteLine(message);
                        break;
                    default:
                        Console.WriteLine("\nValor ingresa no válido en el C A S I N O");
                        break;
                }
            }
        }
    }
}