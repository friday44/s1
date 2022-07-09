﻿// Методы. Вид 1. Не принимает и не передает
/* void Method1()
{
    Console.WriteLine("Автор...");
}
Method1() //скобки обязательны

// Методы. Вид 2. Принимает, но не передает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); */

/* void Method21(string msg, int count)
{
    int i = 0;
    while (i < count);
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); */ //агрументы можно в произвольном порядке, если они именованы

// Методы. Вид 3. Не принимает, только передает
/* int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); */

// Методы. Вид 4. Принимает и передает
/* string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res); */

// с циклом for

/* string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res); */

// цикл в цикле на примере таблицы умножения
/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); 
    }
    Console.WriteLine();
} */


/* Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”. */

/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого"
+ "Винценгероде, вы бы взяли приступом согласие"
+ " прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
 */
// string s = "qwerty"
//             012
// s[3] // r

/* string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'В', 'в');
Console.WriteLine(newText); */


/* Упорядочить массив
1. Найти позицию минимального элемента
в неотсортированной части массива
2. Произвести обмен этого значения со
значением первой неотсортированной позиции
3. Повторять пока есть не отсортированные
элементы */

/* int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
//            0  1  2  3  4  5  6  7  8 

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */

// переделать код, чтобы упорядочивание шло от большего к меньшему
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int maxPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] > array[maxPosition])
 {
 maxPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[maxPosition];
 array[maxPosition] = temporary;
 }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);