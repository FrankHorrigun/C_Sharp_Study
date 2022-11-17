// Задать рандомный массив и поменять строки со столбцами

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    // int col = rnd.Next(0, 10);
    // int row = rnd.Next(0, 10);
    int[,] getArray = new int[4, 4];
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

int[,] SwitchRowColInAarray(int[,] array)// способ через новый массив
{
    int[,] switchArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            switchArray[i, j] = array[j, i];
        }
    }
    return switchArray;
}

void SwitchRowColInAarray2(int[,] array)//перезапись старого
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)//чтобы не перезаписывать поменяные  j<i!! Альтернатива (j=i; j<array.GetLength(1); j++)
        {
            temp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = temp;
        }
    }
}

int[,] randomArray = CreateRandomArray();
PrintArray(randomArray);
Console.WriteLine();

int[,] resultArray = SwitchRowColInAarray(randomArray);
PrintArray(resultArray);
Console.WriteLine();

SwitchRowColInAarray2(randomArray);
PrintArray(randomArray);
Console.WriteLine();

