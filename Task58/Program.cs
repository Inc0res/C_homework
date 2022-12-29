internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = 2;
        int[,] matrixA = new int[n, n];
        int[,] matrixB = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixA[i, j] = rnd.Next(0, 9);
                matrixB[i, j] = rnd.Next(0, 9);
            }
        }
        Console.WriteLine("Matrix A:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrixA[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMatrix B:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrixB[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMatrix AB:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int ij = 0;
                for (int k = 0; k < n; k++)
                {
                    ij += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"{ij} ");
            }
            Console.WriteLine();
        }
    }
}