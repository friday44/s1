/* Имеется одномерный массив array из n элементов, требуется
найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу
успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно. */

/* int[] array = { 1, 12, 31, 4, 15, 61, 17, 81 };

int n = array.Length;
int find = 17;
 
int index = 0;

while (index < n)
{
   if(array[index] == find)
   {
       Console.WriteLine(index);
       break;
   }
   index++;
} */


// то же самое с помощью методов

void FillArray(int[] collection) //метод для генерации массива из 10 элементов, рандомных
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(10);
        index++;
    }
}

void PrintArray(int[] col) //метод вывода на экран массива
{
    int count = col.Length;
    int posithon = 0;
    while (posithon < count)
    {
        Console.WriteLine(col[posithon]);
        posithon++;
    }
}

int IndexOf(int[] collection, int find) //метод поиска заданного элемента
{
    int count = collection.Length;
    int index = 0;
    int posithon = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            posithon = index;
            break;
        }
        index++;
        
    }
    return posithon; 
}   

int[] array = new int[10]; //задали массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);