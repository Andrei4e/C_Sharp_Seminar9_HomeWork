//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/*void NumbersToN(int n)
{
    if (n > 0)
    {
        if (n == 1) Console.Write($"{n}");
        else Console.Write($"{n}, ");
        NumbersToN(n - 1);
    }
}

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
NumbersToN(n);*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int SumNumbers(int m, int n, int sum)
{
    if (m <= n)
    {
        sum += m;
        m++;
        sum = SumNumbers(m , n, sum);
    }
    return sum;
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{SumNumbers(m, n , 0)}");*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m > 0 & n == 0) return Akkerman(m - 1, 1);
        else  return Akkerman (m-1,Akkerman(m,n-1));
    }

}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{Akkerman(m, n)}");