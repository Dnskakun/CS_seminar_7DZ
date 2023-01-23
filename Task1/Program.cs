// Задача 47. Задайте двумерный массив размером m*n,
// заполненный случайными вещественными числами.
// Пример: m=3, n=4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количесто строк массива: ");
int rows = GetNumberFromUser();

Console.Write("Введите колиство столбцов массива: ");
int columns = GetNumberFromUser();

double[,] array = FillArray(rows, columns, -10, 10);
PrintArray(array);


//Функции, используемые в программе

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

double[,] FillArray(int m, int n, int minValue, int maxValue)
{
    double[,] inArray = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                inArray[i, j] = Math.Round(rnd.NextDouble()
                *(maxValue - minValue) + minValue, 1);
            }
        }
    return inArray;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


