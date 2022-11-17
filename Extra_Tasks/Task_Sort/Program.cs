// сортировки массивов

using System;
using System.Diagnostics;

int[] CreateRandomArray()
{
    int[] randomArray = new int[100000];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 10);
    }
    return randomArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void BubleSortArray(int[] array)// сравниваем попарно элементы текущий со следующим со свапом
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {

        for (int j = 0; j < array.Length - 1; j++)
        {

            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void SelectionSort(int[] array)//находим мин значение, ставим вначало списка со свапом
{
    for (int i = 0; i < array.Length; i++)
    {

        int temp;
        int indexMin = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
            {
                indexMin = j;
            }
        }
        temp = array[indexMin];
        array[indexMin] = array[i];
        array[i] = temp;



    }
}

void InsertionSort(int[] array)//непонятно но оч интересно https://www.youtube.com/watch?v=wnZePZ6yzOU&list=PLyYun9897J9IRZNtiXHM6gVEKG7DZZNX-&index=17&ab_channel=BasicSloth
{
    int index;
    int currentNumber;
    for (int i = 0; i < array.Length; i++)
    {
        index = i;
        currentNumber = array[i];
        while (index > 0 && currentNumber < array[index - 1])
        {
            array[index] = array[index - 1];
            index--;
        }
        array[index] = currentNumber;
    }
}

void GnomeSort(int[] array)
{
    int index = 1;
    int nextIndex = index + 1;
    int temp;
    while (index < array.Length)
    {
        if (array[index - 1] < array[index])
        {
            index = nextIndex;
            nextIndex++;
        }
        else
        {
            temp = array[index - 1];
            array[index - 1] = array[index];
            array[index] = temp;
            index--;
            if (index == 0)
            {
                index = nextIndex;
                index++;

            }
        }
    }
}

int FindPivot(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;
    int temp = 0;
    for (int i = minIndex; i < maxIndex; i++)
    {
        if (array[i] < maxIndex)
        {
            pivot++;
            temp = array[pivot];
            array[pivot] = array[i];
            array[i] = temp;

        }
    }
    pivot++;
    temp = array[pivot];
    array[pivot] = array[maxIndex];
    array[maxIndex] = temp;

    return pivot;
}
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }
    int pivod = FindPivot(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivod - 1);
    QuickSort(array, pivod + 1, maxIndex);
    return array;
}

void MainQuickSort(int[] array)
{
    array = QuickSort(array, 0, array.Length - 1);
}
// void Stopwatch(selectionMethod)//делегаты потом разберемся
// {
//     var time = Stopwatch.StartNew();
//     stopwatch.Stop();
//     Console.WriteLine($"Time{selectionMetod}= {stopWatch.ElapsedMilliseconds}");
// }
int[] newArray1 = CreateRandomArray();
var stopWatch1 = Stopwatch.StartNew();
BubleSortArray(newArray1);
stopWatch1.Stop();
Console.WriteLine($"Time BubleSort= {stopWatch1.ElapsedMilliseconds}");

int[] newArray2 = CreateRandomArray();
var stopWatch2 = Stopwatch.StartNew();
SelectionSort(newArray2);
stopWatch2.Stop();
Console.WriteLine($"Time SelectionSort= {stopWatch2.ElapsedMilliseconds}");

int[] newArray3 = CreateRandomArray();
var stopWatch3 = Stopwatch.StartNew();
InsertionSort(newArray3);
stopWatch3.Stop();
Console.WriteLine($"Time InsertSort= {stopWatch3.ElapsedMilliseconds}");

int[] newArray4 = CreateRandomArray();
var stopWatch4 = Stopwatch.StartNew();
GnomeSort(newArray4);
stopWatch4.Stop();
Console.WriteLine($"Time GnomeSort= {stopWatch4.ElapsedMilliseconds}");

int[] newArray5 = CreateRandomArray();
var stopWatch5 = Stopwatch.StartNew();
MainQuickSort(newArray5);
stopWatch4.Stop();
Console.WriteLine($"Time QuickSort= {stopWatch5.ElapsedMilliseconds}");


