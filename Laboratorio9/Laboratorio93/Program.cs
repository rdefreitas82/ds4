internal class Program
{
    private static void Main(string[] args)
    {
        int lado1, lado2, lado3;
        lado1 = leerEntero("Ingrese el primer lado del triangulo: ");
        lado2 = leerEntero("Ingrese el segundo lado del triangulo: ");
        lado3 = leerEntero("Ingrese el tercer lado del triangulo: ");

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2
            && lado2 + lado3 > lado1)
        {
            Console.Write("Los lados ingresados forman un triangulo");
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine(" equilatero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine(" isosceles.");
            }
            else
            {
                Console.Write(" escaleno.");
            }
            
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triangulo");
        }


    }

    private static int leerEntero(string mensaje)
    {
        int numero;
        do
        {
            Console.Write(mensaje);
            try
            {
                numero = Int32.Parse(Console.ReadLine());
                if (numero > 0)
                    return numero;
                else
                    Console.WriteLine("El número debe ser mayor a cero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        } while (true);

    }
}