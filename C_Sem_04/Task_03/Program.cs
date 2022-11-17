// принимает число N и выдает сумму числе от 1 до N

int A = int.Parse(Console.ReadLine());
bool IsInputValid(int a)
{
    if(a <= 1)
        return false;
    return true;
}


int CalculateSum(int a)
{
    int result = 0;
    for(int i = 1; i <= a; i++)
    {
        result += i;
    }
    return result;
}

bool IsValid = IsInputValid(A);
if(IsValid)
{
    int sum = CalculateSum(A);
    Console.WriteLine("Ответ = " +sum);
}
else
{
    Console.WriteLine("Invalid");
}




