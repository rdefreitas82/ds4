namespace Laboratorio31
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int primerNumero, segundoNumero;

            Console.Write("Por favor ingrese el primer número: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Por favor ingrese el segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("({0} + {1}) * ({0} - {1}) = {2}", primerNumero, segundoNumero, CalculosMatematicos.Calcular(primerNumero, segundoNumero));
        }

    }

    public class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}