// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArrayFromString(string input)
{
    string[] stringArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] array = new double[stringArray.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = double.Parse(stringArray[i]);
    }
    return array;
}

double MaxMinNumbersMargin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    double Margin = max - min;
    return Margin;

}

Console.WriteLine("InputArray");
string InputArray = Console.ReadLine();
double[] array = GetArrayFromString(InputArray);
string printArray = string.Join(", ", array);
double Margin = MaxMinNumbersMargin(array);
Console.WriteLine("[" +printArray +"]");
Console.WriteLine("Разница между Max и Min равна: " +Margin);


