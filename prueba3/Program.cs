using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cuantos años tienes : ");
        string añosTxt = Console.ReadLine();
        int años = int.Parse(añosTxt);

        Console.WriteLine("Ingrese dependiendo la edad que tiene");
        Console.WriteLine("1. Mayor de edad");
        Console.WriteLine("2. Menor de edad");
        Console.Write("Seleccione una opción (1/2): ");

        string edadTxt = Console.ReadLine();
        int opcion = int.Parse(edadTxt);

        Console.WriteLine("Ingrese la cantidad de adivinanzas acertadas:");
        string adivinanzasTxt = Console.ReadLine();
        int adivinanzas = int.Parse(adivinanzasTxt);

        float montoInicial = 0f;

        switch (opcion)
        {
            case 1:
                if (adivinanzas <= 3)
                {
                    montoInicial = 30.0f;
                }
                else if (adivinanzas >= 4)
                {
                    montoInicial = 50.0f;
                }
                break;

            case 2:
                if (adivinanzas <= 3)
                {
                    montoInicial = 50.0f;
                }
                else
                {
                    montoInicial = 80.0f;
                }
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }

        float montoExtra = (años * 5.0f) + (adivinanzas * 2.0f);
        float montoFinal = montoInicial + montoExtra;
        Console.WriteLine("El monto final del ganador es: s./" + montoFinal );
    }
}
