// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
// массив вводим с консольки

string Array1(string[] array)
{
    
    string[] ResultArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        ResultArray[i] = array[i];
    }
    string result = string.Join(", " , ResultArray);
    return result;
}









Console.WriteLine("Input array");
string inputArray = Console.ReadLine();
string[] Array = inputArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string result = Array1(Array);
Console.WriteLine(result);

