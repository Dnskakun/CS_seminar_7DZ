// Программа принимает на вход позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого
// элемента нет.

Console.Clear();

int[,] array = FillArray(7, 7, 0, 100);

PrintArray(array);

Console.Write("Введите номер позиции числа массива по горизонтали: ");
int indexColumns = GetNumberFromUser();

Console.Write("Введите номер позиции числа массива по вертикали: ");
int indexRows = GetNumberFromUser();

CheckArray(indexRows, indexColumns, array);


// Функции, используемые в программе
int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        arr[i, j] = rnd.Next(minValue, maxValue);
    }
    return arr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода!");
    }
}

void CheckArray(int indRows, int indCol, int[,] arr)
{
    if (indRows <= arr.GetLength(0) && indCol <= arr.GetLength(1))
    {
        Console.WriteLine($"На данной позиции стоит число {arr[indRows - 1, indCol - 1]}");
    }
    else Console.WriteLine("На данной позиции в массиве нет числа.");
}


