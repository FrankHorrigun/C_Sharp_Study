// задайте одномерный массив из 123 случайных чисел. найдите количество элементов которые лежат в отрезке от 10 до 99.

int[]  CreateRandomArray()
{
    int[] newArray = new int[123];
    for(int i = 1; i < 123; i++)
    {
        newArray[i] = new Random().Next(0, 124);
    }
    return newArray;
}

int NumberCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}


int[] randomArray = CreateRandomArray();
int count = NumberCount(randomArray);
string printArray = string.Join(",", randomArray);
Console.WriteLine(printArray);
Console.WriteLine("Count = " +count);

///РАБОБАЕТ СУКА БЛЯ НАКОНЕЦ