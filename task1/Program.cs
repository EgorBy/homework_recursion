// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int M = 3;
int N = 11;

void GetDigits(int num)
{
    if (num <= M)
    {
        Console.Write($"{num} ");
    }
    else
    {
        GetDigits(num - 1);
        Console.Write($"{num} ");
    }
}

GetDigits(N);
