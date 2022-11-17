// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// (Округление до 2х знаков - Math.Round(value, 2))

// Console.Clear();
int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
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

void ColAriphmeticMean(int[,] array)
{

    for (int col = 0; col < array.GetLength(1); col++)
    {
        double sumNumbersInCol = 0;
        double colAriphmeticalMean = array[0,0];
        int numberOfElemensInCol = array.GetLength(0);
        for (int row = 0; row < array.GetLength(0); row++)
        {
            sumNumbersInCol += array[row, col];
        }
        colAriphmeticalMean = Math.Round(sumNumbersInCol / numberOfElemensInCol, 2);
        Console.WriteLine($"Среднее арифметическое {col + 1} столбца равно {colAriphmeticalMean}");
    }
}




int col = new Random().Next(1, 10);
int row = new Random().Next(1, 10);
int[,] randomArray = CreateRandomArray(col, row);
PrintArray(randomArray);
ColAriphmeticMean(randomArray);