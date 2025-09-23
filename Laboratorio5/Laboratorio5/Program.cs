internal class Program
{
    private static void Main(string[] args)
    {
        int[] valores; // valores sin iniciar
        valores = new int[100]; // 100 elementos
        valores = new int[20]; // ahora continene 20 elementos

        // Arreglos unidimensionales o de de dimensi'on simple

        int[] valores1; // sin inicializar
        int[] valores2 = new int[50];

        // Arreglos multidimensionales
        int[,] valores1; // sin inicializar
        int[,] valores2 = new int[3, 7];
        int[,,] valores3 = new int[3, 4, 2];

        // Arreglo  de arreglos
        int[][] matriz; // sin inicializar
        // Los arreglos de arreglos se inicializan de manera diferente
        int[][] matriz = new int[3][];
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = new int[4];
        }
    }
}