// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Массив задать рандомно и вывести в консоль. (i , j - входные данные)

Console.Clear();
int Prompt(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

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

bool IsValidPosition(int[,] array, int indexCol, int indexRow)
{
    if (
        indexCol > array.GetLength(0)
    || indexRow > array.GetLength(1)
    || indexCol < 0
    || indexRow < 0)
        return false;
    else return true;
}

void SearchElementByIndex(int[,] array, int indexCol, int indexRow)
{
    if (IsValidPosition(array, indexCol, indexRow) == false)
        Console.WriteLine("Такого элемента не сущетсвует");
    else
        Console.WriteLine($"Элемент массива = {array[indexCol, indexRow]}");
}

int colNumber = Prompt("Введите позицию элемента в строке");
int rowNumber = Prompt("Введите позицию элемента в столбце");
int col = new Random().Next(1, 10);
int row = new Random().Next(1, 10);
int[,] randomArray = CreateRandomArray(col, row);
PrintArray(randomArray);
SearchElementByIndex(randomArray, colNumber, rowNumber);