// Задайте двумерный массив. Поменяйте местами первую и последнюю строки

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int col = rnd.Next(0, 10);
    int row = rnd.Next(0, 10);
    int[,] getArray = new int[col, row];
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

void SwitchRowInArray(int[,] array)
{
    int temp;
    for (int col = 0; col < array.GetLength(1); col++)
    {
        temp = array[0, col];
        array[0, col] = array[array.GetLength(0)-1, col];
        array[array.GetLength(0)-1, col] = temp;
    }
}

int[,] randomArray = CreateRandomArray();
PrintArray(randomArray);
SwitchRowInArray(randomArray);
Console.WriteLine();
PrintArray(randomArray);