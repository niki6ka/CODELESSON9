//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.

Console.WriteLine("Please enter the M number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the N number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма элементов от " + m + " до " + n + " = " + SumIntegerNumber(m, n));

int SumIntegerNumber(int m, int n)
    {
    if (m == n)
        return n;
    return n + SumIntegerNumber(m, n - 1);
    }

