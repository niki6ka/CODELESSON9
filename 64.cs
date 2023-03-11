//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Please enter the number: ");
int Second = Convert.ToInt32(Console.ReadLine());
int First = 1;
Console.WriteLine(IntegerNumber(Second, First));

int IntegerNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write(IntegerNumber(n, m + 1) + " ");
    return m;
}
