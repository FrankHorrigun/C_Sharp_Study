//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void CreateCubeArray()
{
    Random rnd = new Next();
    int x = rnd.Next(0, 10);
    nt y = rnd.Next(0, 10);
    nt z = rnd.Next(0, 10);

    int[,,] cube = new int[x, y, z];
    int[] check = new int[x, y, z];
    for (int i = 0; cube.GetLength(0); i++)
    {
        for (int j = 0; cube.GetLength(1); j++)
        {
            for (int k = 0; cube.GetLength(2); k++)

                if(CheckOriginal())
                cube[i, j, k] = rnd.Next(0, 10);
        }
    }
}

bool CheckOriginal(int[] check, int input)
{
    for(int i = 0; i<check.Length; i++)
    {
        if (input == check[i]) return false;
    }
}