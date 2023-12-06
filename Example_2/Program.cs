//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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



int row = ReadData("Количество строк массива: ");
int col = ReadData("Количество столбцов массива: ");

int[,] array = GenerateMatrix(row, col, -10, 10);

PrintMatrix(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    // Думаю, что нужно пройтись только по столбцу с индексом [0]
    // Поскольку строки и столбцы вводит пользователь
    // Наверное, Потребуется создать новый массив, который будет менять строки из заданного пользователем массива.
    // Затрудняюсь с реализацией задачи. 

    // Есть решение если бы наш массив был 4 на 4: 
    // var tmp = array[3, i];
    // array[3, i] = array[0, i];
    // array[0, i] = tmp;
}

System.Console.WriteLine("");
PrintMatrix(array);