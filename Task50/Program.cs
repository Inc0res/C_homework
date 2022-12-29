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
                array[i, j] = rnd.Next(-10, 10);
            }
        }
        string[] numbers = Console.ReadLine().Split(" ");
        int x = int.Parse(numbers[0]);
        int y = int.Parse(numbers[1]);
        if (x > m || y > n)
        {
            Console.WriteLine("No such position");
        }
        else
        {
            Console.WriteLine(array[x, y]);
        }
        Console.WriteLine("Array:");
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