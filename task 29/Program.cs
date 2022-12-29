// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear();
int array.Length < 8;
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.WriteLine ($"{string.Join(", ", array)}");