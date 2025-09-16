namespace Laboratorio32
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            double radio;

            Console.Write("Por favor ingrese el radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El área del circulo con radio {0:F2} es {1:F2}", radio, CalculosMatematicos.CalculoArea(radio));
        }

    }

    public class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }

        public static double CalculoArea(double radio)
        {
            return Math.PI * radio * radio;
        }
    }
}