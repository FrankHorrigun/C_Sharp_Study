//Array         0  1    2   3   4    5   6   7    8
int[] array = {1, 25, 59, 45, 59, 612, 76, 845, 911};
int n = array.Length;
int find = 59;
int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }


    index++;
}
    


