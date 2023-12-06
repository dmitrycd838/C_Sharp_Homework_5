// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int ReadData(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int arraySum(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}


int row = ReadData("Количество строк массива: ");
int col = ReadData("Количество столбцов массива: ");
int leftRange = ReadData("Левая граница массива: ");
int rightRange = ReadData("Правая граница массива: ");

int[,] allarray = GenerateMatrix(row, col, leftRange, rightRange);

System.Console.WriteLine("Исходный массив: ");
PrintMatrix(allarray);

int minSum = 0;
int sumLine = arraySum(allarray, 0);
for (int i = 1; i < allarray.GetLength(0); i++)
{
    int tempSumLine = arraySum(allarray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSum = i;
    }
}
minSum++;

System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой равна: " + minSum);
System.Console.Write("Наименьшая сумма равна: " + sumLine);