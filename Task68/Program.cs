internal class Program
{
    private static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(A(m, n));

        static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return A(m - 1, 1);
            }
            return A(m - 1, A(m, n - 1));
        }
    }    
}