using System.Runtime.CompilerServices;

internal class Program
{
    private int[] sueldos; // Declaramos un vector

    public void Cargar()
    {
        sueldos = new int[5]; // Inicialimzamos el vector en 5
        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f+1) + ":");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Asignamos los 5 sueldos al vector
        }
    }

    // Muestra los sueldos de los operarios en el vector sueldos[f]
    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for (int f = 0; f < 5; f++)
        {
            Console.Write("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }


    private static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}