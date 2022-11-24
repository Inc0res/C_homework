Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;
if (b>a)max = b;
if (a<b)min = a;
Console.WriteLine(max + " Максимум");

Console.WriteLine(min + " Минимум");