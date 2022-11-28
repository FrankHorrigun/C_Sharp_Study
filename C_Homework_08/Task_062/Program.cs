// Напишите программу, которая заполнит спирально массив n на n.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {
        Console.WriteLine("Введите число больше нуля ");
        Console.WriteLine(message);
    }
    return value;
}


int[,] CreateSpiralMatrix(int n)
{
    int[,] a = new int[n, n];

    int i = 0, j = 0;

    int value = 1;

    while (n != 0)
    {
        int k = 0;
        do { a[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) a[i++, j] = value++;
        for (k = 0; k < n - 1; k++) a[i, j--] = value++;
        for (k = 0; k < n - 1; k++) a[i--, j] = value++;

        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }
    return a;

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int n = Prompt("Введите размер матрицы");
int[,] spiralMatrix = CreateSpiralMatrix(n);
PrintArray(spiralMatrix);