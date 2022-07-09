// поиск максимального из 9 чисел с помощью массива

int Max (int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if (arg2 > resalt) resalt = arg2;
    if (arg3 > resalt) resalt = arg3;
    return resalt;
}
//              0   1   2   3   4   5   6   7   8
int[] array = {11, 2441, 31, 41, 15, 16, 71, 81, 19};

//array[0] = 12; обращение к элементу массива, запись новогозначения

//Console.WriteLine(array[4]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);