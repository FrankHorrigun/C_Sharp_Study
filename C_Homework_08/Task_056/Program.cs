//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int[,] CreateRandomMatrix()
{
    Random rnd = new Random();
    int x = rnd.Next(2, 10);
    int[,] randomArray = new int[x, x];
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

int[] SumOfElementsInRowofArray(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        sumRow[i] = sum;
    }
    return sumRow;
}

void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

    void PrintMin(int[] array)
    {
        int indexMin = 0;
        for (int i = 1; i < array.GetLength(0); i++)
        {
            if (array[i] < array[indexMin])
            {
                indexMin = i;
            }
        }
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin+1} строка");
    }

    int[,] randomMatrix = CreateRandomMatrix();
    PrintArray(randomMatrix);

    int[] resultArray = SumOfElementsInRowofArray(randomMatrix);
    PrintArray2(resultArray);
    Console.WriteLine();

    PrintMin(resultArray);
    



