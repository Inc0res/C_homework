internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Number count: ");
        int M = int.Parse(Console.ReadLine());
        int[] numbers = new int[M];
        for (int i = 0; i < M; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int positiveCount = 0;
        for (int i = 0; i < M; i++)
        {
            if (numbers[i] > 0)
            {
                positiveCount++;
            }
        }
        Console.WriteLine(positiveCount);
    }
}