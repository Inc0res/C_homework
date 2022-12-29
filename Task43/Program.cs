internal class Program
{
    private static void Main(string[] args)
    {
        float k1, k2, b1, b2;
        Console.Write("k1 = ");
        k1 = float.Parse(Console.ReadLine());
        Console.Write("b1 = ");
        b1 = float.Parse(Console.ReadLine());
        Console.Write("k2 = ");
        k2 = float.Parse(Console.ReadLine());
        Console.Write("b2 = ");
        b2 = float.Parse(Console.ReadLine());
        if (k1 == k2)
        {
            if (b1 == b2)
            {
                Console.WriteLine("Infinite number of solutions");
            }
            else
            {
                Console.WriteLine("No solutions");
            }
        }
        else
        {
            float x = (b2 - b1) / (k1 - k2);
            float y = k1 * x + b1;
            Console.WriteLine($"({x}; {y})");
        }
    }
}