


System.Console.WriteLine("Введите размеры массива: ");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random rand = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = rand.Next(-10, 10);
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        System.Console.Write(array[i, j] + "\t  ");
    }       
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите координаты: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > m && b > n)
    System.Console.WriteLine("Такого числа нет");
else
{
    object c = array.GetValue(a, b)!;
    System.Console.WriteLine(c);
}