//Methods
int Max(int arg1, int arg2, int arg3) //Max название метода
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 45;
int b1 = 78;
int c1 = 56;

int a2 = 54;
int b2 = 7567;
int c2 = 12;

int a3 = 69;
int b3 = 246533;
int c3 = 67;

//int max1 = Max(a1, b1, c1); // Обращаемся к методу Мах
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

int max = Max(
    Max(a1, b1, c1), //В аргумент функции можно вставить функцию!!!!
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);
