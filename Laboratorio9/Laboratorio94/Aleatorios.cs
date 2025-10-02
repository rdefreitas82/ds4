namespace Laboratorio94
{
    class Aleatorios
    {
        private static Random random = new Random();
        public static int generar(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static int[] arreglo(int n, int min, int max)
        {
            int[] arreglo = new int[n];

            if (n > ((max + 1) - min))
                throw new ArgumentException("El tamaño del arreglo es mayor que el rango de valores posibles, por lo que los valores no pueden ser unicos.");


            for (int i = 0; i < n; i++)
            {
                arreglo[i] = generar(min, max);
                for (int j = 0; j < i; j++)
                {
                    if (arreglo[i] != arreglo[j])
                    {
                        continue;
                    }
                    else
                    {
                        arreglo[i] = generar(min, max);
                        j = -1;
                    }
                }

            }
            return arreglo;
        }
    }
}

