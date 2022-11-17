// создать массив и заменить отрицательные элементы на такие же положительные и наобором и вывести

int GetValue(string message)
{
    Console.WriteLine(message);
    int x = int.Parse(Console.ReadLine());
    return x;
}


int[] CreateRandomArray(int N, int min, int max)
{
    int[] x = new int[N];
    for(int i = 0; i < N; i++)
    {
        x[i] = new Random().Next(min, max+1);
    }
    return x;
}

int[] GetinvertArray(int[] startArray);
{
    int[] y = new int[startArray.Length];
    for(int i = 0; i < y.Length; i++)
    {
        y[i] = - startArray[i];
    }
    return y;
}


int N = GetValue("Input N");
int min = GetValue("Input min");
int max = GetValue("Input max");
int[] startArray = CreateRandomArray(N, min, max);
int[] invertArray = GetinvertArray(startArray);

string inputString = string.Join(", ", startArray);
Console.WriteLine(inputString);
string inputString = string.Join(", ", invertArray);
Console.WriteLine(inputString);


//НЕ РАБОТАЕТ