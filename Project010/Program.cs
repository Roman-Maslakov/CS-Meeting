int[] array = { 12, 234, 3123, 44, 543, 3737, 75, 12, 81, 93 };

int n = array.Length;

Console.WriteLine("Gimme a number");
int find = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i < n)
{
    if (array[i] == find)
    {
        Console.Write("The sought index is ");
        Console.Write(i);
        break;
    }
    i++;
}


