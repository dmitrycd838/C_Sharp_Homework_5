int ReadInt(string text)
{
    System.Console.Write(text); // чтобы пользователь мог ввести некоторый текс, чтобы выражение не было константным. 
    return Convert.ToInt32(Console.ReadLine()); // возвращаем значение из терминала. 
}

// Возвращаем двумерный массив
int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange) // В параметры функции указываем количество строк и столбцов (можно добавить 2 переменные с границами генерации)
{
    // Задаём временный массив. По количеству строк и количеству столбцов переданных в функцию. 
    int[,] matrix = new int[row, col];
    // Объявляем экземляр класса Random, для генерации случайных чисел
    Random rand = new Random();
    // Используем цикл в цикле, для того, чтобы пройтись по всем элементам массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1); // +1 для того, чтобы правая граница уже включала заданное число. 
        }
    }
    return matrix;
}

// Выводим все элементы массива на экран
// 1. Создаём функцию, которая не возвращает значения. Внутрь принимает метод, который будет выводить в консоль.  
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

double[] FindAverageInRows(int[,] matrix)
{
    double[] averageArray = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averageArray[i] += matrix[i, j];
        }
        averageArray[i] = Math.Round(averageArray[i] / matrix.GetLength(1), 2);
    }
    return averageArray;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine($"Среднее арифметическое строк массива: [" + string.Join(" | ", array) + "]");
}

// Задаём переменную, которая будет равна результату работы метода ReadInt
int rows = ReadInt("Введите количество строк массива: ");
// Задаём вторую переменную, которая также ссылается на результат работы нашей функции. 
int cols = ReadInt("Введите количество столбцов массива: ");

// Заполнение массива
// Задаём массив, который равен методу GenerateMatrix описанный выше. c аргументами от пользователя и вручную заданными границами. 

int[,] matrix = GenerateMatrix(rows, cols, -9, 9);

double[] averageArray = FindAverageInRows(matrix);

PrintMatrix(matrix);

PrintArray(averageArray);

// Реализация без выноса в функцию

// double[] averageArray = new double[matrix.GetLength(0)];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         averageArray[i] += matrix[i, j];     // Обращаем к методу avarageArray по индексу [i] прибавляем к ней значения матрицы i, j
//     }
//     avaregeArray[i] /= matrix.GetLength(1);  // После прохождения всего цикла у нас в индексе i. будет лежать сумма всех элементов
// }                                            // Нулевой строки. 
//                                              // После прохождения всех элементов строки, делим их на количество столбцов.             

// System.Console.WriteLine($"Среднее арифметическое строк массива: [" + string.Join(" | ", averageArray) + "]");


