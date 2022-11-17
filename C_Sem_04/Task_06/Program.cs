// делаем массив из 8 элементов и рандомно заполняем 0 и 1
void CreateArray(int[] array)
{
    for(int i = 0; i < array.Length; i++);
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for(int j = 0; j < array.Length; j++);
    {
        Console.Write($"{array[j]}");
    }
}

int[] array = new int[8];
CreateArray(array);
PrintArray(array);
