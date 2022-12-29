internal class Program
{
    private static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(SumInterval(M, N));

        static int SumInterval(int x, int y)
        {
            if (x > y)
            {
                return 0;
            }
            if (x == y)
            {
                return x;
            }
            if (x == y - 1)
            {
                return x + y;
            }
            return SumInterval(x, (x + y) / 2) + SumInterval((x + y) / 2 + 1, y);
        }
    }
}