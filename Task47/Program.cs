internal class Program
{
    private static void Main(string[] args)
    {
        int m, n;
        Console.Write("m = ");
        m = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        double[,] array = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.NextDouble() * 20 - 10;
                Console.Write("{0:0.#} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}