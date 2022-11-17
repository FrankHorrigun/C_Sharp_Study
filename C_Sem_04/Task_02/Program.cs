// See расстояние между 2 точка в трехмерном пространстве через массив

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] ReadPoint()
{
    int x_index = 0;
    int y_index = 1;
    int z_index = 2;
    int[] point = new int[3];
    point[x_index] = Prompt("Введите Х");
    point[y_index] = Prompt("Введите Y");
    point[z_index] = Prompt("Введите Z");
    return point;
}

double CalculateDistance(int[] PointA, int[] PointB)
{
    double distance = Math.Sqrt(SumSquare(PointA, PointB));
    return distance;
}

double SumSquare(int[] PointA, int[] PointB)
{
    double sum = 0;
    for(int index = 0; index < PointA.Length; index++)
    {
        sum += Math.Pow(PointA[index] - PointB[index], 2);
    }
    return sum;
}

int[] PointA = ReadPoint();
int[] PointB = ReadPoint();
double distance = CalculateDistance(PointA, PointB);
Console.WriteLine("Distance = " +distance);
