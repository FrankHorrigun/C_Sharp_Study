// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

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


int[,] CreateMatrix(int a, int b)
{
    Random rnd = new Random();
    int x = rnd.Next(2, 10);
    int[,] randomArray = new int[a, b];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rnd.Next(0, 10);
        }
    }
    return randomArray;
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

int[,] CompositionMatrix(int[,] matrix1, int[,] matrix2)
{
    int size = matrix1.GetLength(0);
    int[,] compositionMatrix = new int[size, size];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
            compositionMatrix[i, k] += matrix1[i, j] * matrix2[j, i];
            }
        }
    }
    return compositionMatrix;
}


int a = Prompt("Введите число рядов");
int b = Prompt("Введите число столбцов");

int[,] matrix1 = CreateMatrix(a, b);
Console.WriteLine("Matrix1 =");
PrintArray(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrix(b, a);
Console.WriteLine("Matrix2 =");
PrintArray(matrix2);
Console.WriteLine();

int[,] compositionMatrix = CompositionMatrix(matrix1, matrix2);
Console.WriteLine("Composition matrix =");
PrintArray(compositionMatrix);