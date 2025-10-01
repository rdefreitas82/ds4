using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        double valorProducto;
        bool tarjeta = false;
        string numeroTarjeta = "";
        do
        {
            Console.Write("Cuál es el valor del producto a pagar: ");
            try
            {
                valorProducto = double.Parse(Console.ReadLine());
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("No se ha ingresado ningún valor, intente de nuevo.");
                continue;
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado no es un número válido, intente de nuevo.");
                continue;
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor ingresado es demasiado grande o demasiado pequeño, intente de nuevo.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error inesperado: {ex.Message}, intente de nuevo.");
                continue;
            }

        } while (true);

        bool banderaFormaPago = true;
        do
        {
            Console.Write("¿Forma de pago, para efectivo (presione 1) o tarjeta (presione 2?): ");
            switch (Console.ReadLine())
            {
                case "1":
                    tarjeta = false;
                    banderaFormaPago = false;
                    break;
                case "2":
                    tarjeta = true;
                    Console.Write("Ingrese el número de tarjeta: ");
                    numeroTarjeta = Console.ReadLine().Trim();
                    banderaFormaPago = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    continue;
            }
        } while (banderaFormaPago);

        if (tarjeta)
        {
            Console.WriteLine($"El monto pagado por el producto fue ${valorProducto:F2} mediante tarjeta numero: {numeroTarjeta}.");
        }
        else
        {
            Console.WriteLine($"El monto pagado por el producto fue ${valorProducto:F2} en efectivo.");
        }
    }
}