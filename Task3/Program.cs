// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце
// Задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] array = FillArray(3, 4, 0, 9);
PrintArray(array);
AverageSumColumns(array);


// Функции, используемые в программе
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] inArray = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        inArray[i, j] = rnd.Next(minValue, maxValue + 1);
    }
    return inArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        Console.Write($"{inArray[i, j]} ");
        Console.WriteLine();
    }
}

void AverageSumColumns(int[,] inArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        double result = Math.Round(sum / inArray.GetLength(0), 1);
        if (j == inArray.GetLength(1) - 1) Console.Write($"{result}. ");
        else Console.Write($"{result}; ");
    }
}