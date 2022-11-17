// See Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine());
    return N;
}
bool IsValid(int x)
{
    if(x > 0) return true;
    else return false;
}
int[] CreateRandomArray(int x)
{
    int[] array = new int[x];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int GetEvenNumberAmount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}

int N = GetNumber("Введите длину массива: ");
bool Valid = IsValid(N);
if(Valid == true)
{
    int[] array = CreateRandomArray(N);
    string printArray = string.Join(", ", array);
    Console.WriteLine("[" +printArray +"]");
    int evenNumberAmount = GetEvenNumberAmount(array);
    Console.WriteLine("Количество четных чисел в массиве = " +evenNumberAmount);
}
else
{
Console.WriteLine("Введите положительное число больше нуля");
}



