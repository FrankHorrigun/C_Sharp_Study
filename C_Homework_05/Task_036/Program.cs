// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
bool IsValidLength(int N)
{
    if(N <= 0)
    {
        return false;
    }
    else return true;
}
bool IsValidRange(int min, int max)
{
    if(min > max)
    {
       return false; 
    }
    else return true;
}

int[] CreateArray(int N, int min, int max)
{
    int[] array = new int[N];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int SumNumbersOddIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}

int arrayLength = GetNumber("Введите длину массива: ");
int min = GetNumber("Введите диапазон чисел от min: ");
int max = GetNumber("Введите диапазон чисел до max: ");
bool ValidLength = IsValidLength(arrayLength);
bool ValidRange =IsValidRange(min, max);

if(ValidLength == false)
{
    Console.WriteLine("Длина массива должна быть больше нуля");
}
if(ValidRange == false)
{
    Console.WriteLine("min должно быть не больше max");
}
if(ValidLength == true && ValidRange == true)
{
    int[] array = CreateArray(arrayLength, min, max);
    string printArray = string.Join(", ", array);
    Console.WriteLine("[" + printArray +"]");
    int sum = SumNumbersOddIndex(array);
    Console.WriteLine("Сумма элементов на нечентых позициях равна " +sum);
}


