// задать массив. определить присутствует ли заданное число в массиве

int GetValue(string message)
{
    Console.WriteLine(message);
    int x = int.Parse(Console.ReadLine());
    return x;
}

string GetArrayString(string message)
{
    Console.WriteLine(message);
    string array1 = Console.ReadLine();
    return array1;
}

int[] ConvertToArray(string x)
{
    string[] y = x.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[y.Length];
    for(int i = 0; i < x.Length; i++)
    {
        array[i] = int.Parse(y[i]);
    }
    return array;
}

bool Exist(int[] w, int q)
{
    for(int i = 0; i < w.Length; i++)
    {
        if(w[i] == q)
        {
            return true;
            break;
        }
        else return false;   
    }
}


int N = GetValue("Input N");
string array = GetArrayString("Input array");
int[] array1 = ConvertToArray(array);
bool result = Exist(array1, N);

string resprintarray = string.Join(",", array1);
Console.WriteLine(resprintarray +" " +result);


//НЕ РАБОТАЕТ СУКА