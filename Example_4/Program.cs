// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] GenetaMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] temMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < temMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < temMatrix.GetLength(1); j++)
        {
            temMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return temMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindMinNumberIndexes(int[,] matrix, out int iIndex, out int jIndex)
{
    iIndex = 0;
    jIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[iIndex, jIndex]) // Алгоритм поиска индекса минимального числа
            {
                iIndex = i;
                jIndex = j;
            }
        }

    }
}

int[,] DeleteRowAndCol(int[,] matrix, int iMin, int jMin) // Создаём массив, который будет указывать на позиции элемента, который нужно удалить
{
    // Выделим память под новый массив, который будет хранить память на единицу меньше, чем исходный массив
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    // Создаём 2 переменные счётчика. Одна будет проходить по исходному массиву, другая по новому массиву.
    for ( int i = 0, x = 0; i < matrix.GetLength(0); i++)
    {   
        if(i == iMin) continue; // Если элемент i, будет на той строке, где минимальный элемент - эту строку пропускаем
        for ( int j = 0, y = 0; j < matrix.GetLength(1); j++)
        {
            if ( j == jMin) continue;

            newMatrix[x, y] = matrix[i, j]; // в новый массив по индексам, копируем значения из старого массива
            y++;
        }   // Если цикл встретился со строкой или столбцом в старом массиве,
           //  в которой содержится минимальный элемент, строчка пропускается путём увеличения переменной y или j
        x++;
    }

    return newMatrix;
}
//------------------
int[,] oldMatrix = GenetaMatrix(5, 7, -10, 10);
PrintMatrix(oldMatrix);
FindMinNumberIndexes(oldMatrix, out int iMin, out int jMin);
System.Console.WriteLine();
System.Console.WriteLine(iMin + " " + jMin);
System.Console.WriteLine();
PrintMatrix(DeleteRowAndCol(oldMatrix, iMin, jMin));

