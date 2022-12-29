internal class Program
{
    private static void Main(string[] args)
    {
        int size = 4;
        int[,] array = new int[size, size];
        int i = 1;
        for (int round = 0; round < size / 2; round++)
        {
            if (round == size / 2 - 1 && size % 2 == 0)
            {
                array[round, round] = i++;
                array[round, size - round - 1] = i++;
                array[size - round - 1, size - round - 1] = i++;
                array[size - round - 1, round] = i;
                break;
            }

            for (int j = round; j < size - round - 1; j++)
            {
                array[round, j] = i++;
            }

            for (int j = round; j < size - round - 1; j++)
            {
                array[j, size - round - 1] = i++;
            }

            for (int j = size - round - 1; j > round; j--)
            {
                array[size - round - 1, j] = i++;
            }

            for (int j = size - round - 1; j > round; j--)
            {
                array[j, round] = i++;
            }

            if (round == size / 2 - 1 && size % 2 == 1)
            {
                array[round + 1, round + 1] = i;
                break;
            }
        }
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0:00} ", array[row, col]);
            }
            Console.WriteLine();
        }
    }
}