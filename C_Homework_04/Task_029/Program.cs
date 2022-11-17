// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])

int GetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}

// int NewRandom(int min, int max)//метод генерации
// {
//     int random = new Random().Next(min, max+1);
//     return random;
// }


void FillArray(int[] array1, int min, int max) // заполняем массив
{
    int i = 0;
    while(i < array1.Length)
    {
        array1[i] = new Random().Next(min, max+1);
        i++;
    }
}

void PrintArray(int[] array2)
{
    int j = 0;
    Console.Write("[");
    while(j < array2.Length-1)
    {
        Console.Write(array2[j] +",");
        j++;
    }
    Console.Write(array2[array2.Length-1] +"]");
    Console.WriteLine();
}

int N = GetValue("Введите N");
int min = GetValue("Введите min");
int max = GetValue("Введите max");

if (N > 0)
    {
        if (min < max)
        {
            int[] array = new int[N];
            FillArray(array, min, max);
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("Error. Min значение должно быть меньше Max");
        }
    }
    else
    {
        Console.WriteLine("Error. N должно быть больше 0");
    }
