// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool IsInputLengthValid(int number)
{
    if (number <= 0)
        return false;
    else return true;
}

int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] array = new int[n, m];
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            array[row, col] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}

int n = Prompt("Введите число строк ");
int m = Prompt("Введите число столбцов ");


int[,] newArray = CreateArray(n, m, -10, 10);
PrintArray(newArray);