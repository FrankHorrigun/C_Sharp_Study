// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int Prompt(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SummElements(int[,] array)
{
    int minLength = array.GetLength(0);
    int result = 0;
    if (minLength > array.GetLength(1))
        minLength = array.GetLength(1);
    for (int i = 0; i < minLength; i++)
    {
        result += array[i, i];
    }
    Console.WriteLine($"Сумма элементов диагонали равно {result}");
}

int n = Prompt("Введите число строк");
int m = Prompt("Введите число столбцов");

int[,] matrix = CreateArray(m, n);
PrintArray(matrix);
Console.WriteLine();
SummElements(matrix);

