//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int Prompt(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {
        Console.WriteLine("Введите число больше нуля ");
        Console.WriteLine(message);
    }
    return value;
}


int[,,] CreateMatrix(int row, int col, int dep)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GetUniqueValue(matrix, i, j, k);
            }
        }
    }
    return matrix;
}

int GetUniqueValue(int[,,] matrix, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        Random rnd = new Random();
        value = rnd.Next(10, 100);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],1} ({i}, {j}, {k})|");
            }
            Console.WriteLine();
        }
    }
}


int row = Prompt("Введите высоту матрицы");
int col = Prompt("Введите ширину матрицы");
int depth = Prompt("Введите глубину матрицы");

int[,,] matrix3D = CreateMatrix(row, col, depth);
PrintMatrix(matrix3D);
