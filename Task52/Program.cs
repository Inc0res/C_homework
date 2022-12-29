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
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
            double average = sum / (float)m;
            Console.Write("{0:0.#} ", average);
        }
    }
}