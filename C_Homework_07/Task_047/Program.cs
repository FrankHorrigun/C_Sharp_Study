// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//(Округление до 2х знаков - Math.Round(value, 2))

int Prompt(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rnd = new Random();
            array[i, j] = Math.Round(rnd.NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

bool IsValid(int a, int b)
{
    if (a > 0 && b > 0)
        return true;
    else return false;
}

int m = Prompt("Введите число строк");
int n = Prompt("Введите число столбцов");

if (IsValid(m, n))
{
    double[,] matrix = CreateArray(m, n);
    PrintArray(matrix);
    Console.WriteLine();
}
else Console.WriteLine("Число строк и столбцов должно быть больше 0");