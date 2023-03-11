
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Please enter the M number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the N number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A " + m +"," + n + " = " + Akker(m, n));

int Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akker(m - 1, 1);
    else
        return Akker(m - 1, Akker(m, n - 1));
}