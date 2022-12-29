internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int m = rnd.Next(3, 6);
        int n = rnd.Next(3, 6);
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.Next(0, 10);
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        int minSumRow = 0;
        int minSum = 0;
        for (int j = 0; j < n; j++)
        {
            minSum += array[0, j];
        }
        for (int i = 1; i < m; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }
        Console.WriteLine(minSumRow + 1);
    }
}