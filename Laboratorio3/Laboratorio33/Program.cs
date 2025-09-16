internal class Program
{
    private static void Main(string[] args)
    {
        int lado, ancho, perimetro;

        Console.Write("Por favor ingrese el lado del rectángulo: ");
        lado = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor ingrese el ancho del rectángulo: ");
        ancho = Convert.ToInt32(Console.ReadLine());

        perimetro = 2 * (lado + ancho);

        Console.WriteLine("El perimetro del rectangulo con lado de {0} y ancho de {1} es igual a {2}.", lado, ancho, perimetro);
    }
}