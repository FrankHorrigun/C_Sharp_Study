// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Через метод сплит

int[] GetArrayFromSting(string input)
{
    string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] intArrayFromString = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        intArrayFromString[i] = int.Parse(inputArray[i]);
    }
    return intArrayFromString;
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for ( int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


Console.WriteLine("Введите массив: ");
string input1 = Console.ReadLine();
int[] NewArray = GetArrayFromSting(input1);
Console.WriteLine("Массив: " +string.Join(", ", NewArray));
Console.WriteLine($"Число положительных элементов массива равно " +CountPositiveNumbers(NewArray));


