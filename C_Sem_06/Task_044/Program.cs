// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//  через массивы, число с консоли

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int NumberLength(int x)
{
    int count = 0;
    for(int i = 0; x%10 >0; i++)
    {
        x/=10;
        count++;
    }
    return count;
}
int[] FibArray(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i =2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}


int N = GetNumber("Input N");
int[] array = FibArray(N);
string fibArray = string.Join(" ", array);
Console.WriteLine(fibArray);


