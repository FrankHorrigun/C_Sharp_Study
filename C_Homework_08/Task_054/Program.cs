// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandomMatrix()
{
    Random rnd = new Random();
    int row = rnd.Next(2, 10);
    int col = rnd.Next(2, 10);
    int[,] randomArray = new int[row, col];
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


void SortLowerArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int temp = array[i, k];
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                temp = array[i, j];
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j+1];
                    array[i, j+1] = temp;
                    
                }


            }


        }
    }
}





int[,] newArray = CreateRandomMatrix();
PrintArray(newArray);
Console.WriteLine();
SortLowerArray(newArray);
PrintArray(newArray);