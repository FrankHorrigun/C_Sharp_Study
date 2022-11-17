// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

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

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            array[row, col] = row + col;
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

int m = Prompt("Введите число строк ");
int n = Prompt("Введите число столбцов ");

if (IsInputLengthValid(m) && IsInputLengthValid(n))
{
    int[,] newArray = CreateArray(m, n);
    PrintArray(newArray);
}
else Console.WriteLine("Error");
