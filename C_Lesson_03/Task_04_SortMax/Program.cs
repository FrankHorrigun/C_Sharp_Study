// See https://aka.ms/new-console-template for more information
int[] arr = {1, 9, 7, 2, 5, 6, 4, 3, 0};

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SortMax(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int MaxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[MaxPosition]) MaxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = temporary;
    }
}

PrintArray(arr);
SortMax(arr);
PrintArray(arr);


