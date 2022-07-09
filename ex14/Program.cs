// Cобрать строку с числами от а до b, a<=b

/* string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b} ";
}
Console.WriteLine(NumbersRec(1, 10)); */

// Cобрать строку с числами от а до b, a>=b
/* string NumbersRec(int a, int b)
{
    if (a < b) return NumbersRec(a + 1, b) + $"{a} ";
    else return $"{b} ";
}
Console.WriteLine(NumbersRec(1, 10)); */

//сумма чисел от 1 до n
/* int SumRec (int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10)); */

/* int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10)); */

/* int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
  //  if (n == 0) ? 1 : PowerRec(a, n - 1) * a; тернарный оператор
}
Console.WriteLine(PowerRec(2, 10)); */

/* В некотором машинном алфавите
четыре буквы: «а», «и», «с» и «в». Покажите все
слова, состоящие из T букв, которые можно
построить из букв этого алфавита. */

/* int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    { 
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word [length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]); */

//задача про пирамидки
/* void Towers (string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers (with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers (some, on, with, count - 1);
}
Towers(); */


