// задать массив из 12 элеменнтов с рандомными числами [-9,9] и найти сумму положительных и отрицательных чисел

int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }


int[] input = CreateRandomArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;

for(int i = 0; i < input.Length; i++)
{
    if (input[i] > 0)
    {
        positiveSum += input[i];
    }
    else negativeSum += input[i];
}
// Console.WriteLine(PrintArray[input]);
// Console.WriteLine("PositiveSum= " +positiveSum);
// Console.WriteLine("NegativeSum= " + negativeSum);
string inputString = string.Join(",", input);
Console.WriteLine("Array = " + inputString + " PositiveSum = " + positiveSum +" NegativeSum = " + negativeSum );


