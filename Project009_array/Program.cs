int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}//              0    1     2   3    4   5   6   7   8
int[] array = { 12, 234, 3123, 44, 543, 3737, 75, 81, 93 };

int MAX = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));
Console.WriteLine(MAX);

// int MAX = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
