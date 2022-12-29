internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int m = rnd.Next(3, 6);
        int n = rnd.Next(3, 6);
        int[,] array = new int[m, n];
        Console.WriteLine("Source array:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(0, 10);
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                int max = array[i, j];
                int indexMax = j;
                for (int k = j + 1; k < n; k++)
                {
                    if (array[i, k] > max)
                    {
                        max = array[i, k];
                        indexMax = k;
                    }
                }
                (array[i, j], array[i, indexMax]) = (array[i, indexMax], array[i, j]);
            }
        }
        Console.WriteLine("\nSorted array:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}