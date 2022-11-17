// найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент. Результат запишите в новом массиве

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] resultArray(int[] array)
{
    if(array.Length%2 == 0)
    {
        int[] newArray = new int[array.Length/2];
        for(int i = 0; i < array.Length/2; i++)
        {
            newArray[i] = array[i]*array[array.Length-1 - i];
        }
    }
    else
    {
        int[] newArray = new int[array.Length/2 + 1];
        for(int i = 0; i < array.Length/2; i++)
        {
            newArray[i] = array[i]*array[array.Length-1 - i];
            newArray[array.Length/2] = array[array.Length/2];
        }
    }
    return newArray;
}






Console.WriteLine("InputArray");
string stringArray = Console.ReadLine();
int[] array = GetArrayFromString(stringArray);
string printArray = string.Join(",", array);
Console.WriteLine(printArray);

int[] array2 = resultArray(array);
string printArray2 = string.Join(",", array2);
Console.WriteLine(printArray2);
