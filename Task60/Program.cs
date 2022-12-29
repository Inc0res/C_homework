internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = 3;
        int[,,] array = new int[n, n, n];
        List<int> numbers = new List<int>();
        for (int i = 10; i < 100; i++)
        {
            numbers.Add(i);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    int index = rnd.Next(0, numbers.Count);
                    array[i, j, k] = numbers[index];
                    numbers.RemoveAt(index);
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }
}