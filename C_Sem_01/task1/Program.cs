Console.WriteLine("Ведите число a");
string value1 = Console.ReadLine();
int a = int.Parse(value1);
Console.WriteLine("Ведите число b");
string value2 = Console.ReadLine();
int b = int.Parse(value2);
if (a == b * b)
{
    Console.Write("a является квардатом b");
}

else
{
    Console.Write("a не является квардатом b");
}

