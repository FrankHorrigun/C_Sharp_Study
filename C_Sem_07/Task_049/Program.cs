// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// индексы начинаются с 1

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

void ResultArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
}

int n = Prompt("Введите число строк");
int m = Prompt("Введите число столбцов");
int[,] matrix = CreateArray(m, n);
PrintArray(matrix);
Console.WriteLine();
ResultArray(matrix);
PrintArray(matrix);


