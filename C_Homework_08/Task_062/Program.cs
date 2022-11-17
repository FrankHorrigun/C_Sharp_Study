// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateRandomMatrix()
{
    int[,] randomArray = new int[4, 4];
    randomArray[0, 0] = 1;
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        if (i != randomArray.Length-1)
        {
            for (int j = 1; j < randomArray.GetLength(0); j++)
            {
                randomArray[i, j] = randomArray[i, j - 1] + 1;
            }
        }
        if( i == randomArray.Length-1)
        {
            for( int j = array.MaxLength; j++)
            {
                randomArray[i, j] = randomArray[i, j] + 1;
            }
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

int[,] snakeMatrix = CreateRandomMatrix();
PrintArray(snakeMatrix);