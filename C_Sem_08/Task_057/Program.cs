// Составить частотный словарь двумерного массива. Частотный словарь содержит инфо о том, сколько раз встречается элемент входных данных

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int col = rnd.Next(2, 6);
    int row = rnd.Next(2, 6);
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

int[] ConvertArray(int[,] array)
{
    int k = 0;
    int length = array.GetLength(0) * array.GetLength(1);
    int[] convertedArray = new int[length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            convertedArray[k] = array[i, j];
            k++;
        }
    }
    return convertedArray;
}

void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SelectionSortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                int temp = array[i];
                array[i] = min;
                array[j] = temp;
            }
        }
    }
}

int[] ElementFrequancyInArray(int[] array)
{
    int[] result = new int[array.Length];
    result[0] = 1;
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {

            if (array[j] == array[i])
            {
                count++;
            }

        }
        result[i] = count;
    }
    return result;
}

void PrintFrequancy(int[] array, int[] count)
{
    Console.WriteLine($"{array[0]} встречается {count[0]} раз");
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != array[i - 1])
        {
            Console.WriteLine($"{array[i]} встречается {count[i]} раз");
        }
    }
}

int[,] newArray = CreateRandomArray();
PrintArray(newArray);

Console.WriteLine("Converted array:");
int[] convertedArray = ConvertArray(newArray);
PrintArray2(convertedArray);
Console.WriteLine();

Console.WriteLine("Sorted array:");
SelectionSortArray(convertedArray);
PrintArray2(convertedArray);
Console.WriteLine();

int[] resultArray = ElementFrequancyInArray(convertedArray);
// PrintArray2(resultArray);

Console.WriteLine();
PrintFrequancy(convertedArray, resultArray);

