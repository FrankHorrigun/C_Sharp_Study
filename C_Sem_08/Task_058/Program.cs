// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int col = rnd.Next(3, 4);
    int row = rnd.Next(3, 4);
    int[,] getArray = new int[row, col];
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
         
            getArray[i, j] = rnd.Next(0, 10);
        }
    }
    return getArray;
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

bool IsValid(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        return true;
    }
    else return false;
}

int[,] CompositionMatrix(int[,] array1, int[,] array2)
{

    int[,] resultArray = new int[array1.GetLength(0), array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            resultArray[i, j] += array1[i, j] * array2[j, i];
        }
    }
    return resultArray;

}

int[,] array1 = CreateRandomArray();
int[,] array2 = CreateRandomArray();
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

if (IsValid(array1, array2) == true)
{
    int[,] result  =CompositionMatrix(array1, array2);
    PrintArray(result);
}
else Console.WriteLine("Error");


