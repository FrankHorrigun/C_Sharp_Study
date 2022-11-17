// Array Random
//Метод заполнения массива
void FillArray(int[] collection) //collection - array name/ VoidMethod - не возвращает данные, поэтому return в конце метода не используется
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Присваиваем -1, чтобы при отсутствии искомого выводило -1
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }    
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int[10] - создай новый массив длиной 10
//используем методы
FillArray(array);//пока к методу не обращаются, он ничо не делает. Тут к нему обращаемся, он заполняет наш новый массив рандом числами
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);

