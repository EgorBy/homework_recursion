// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int AckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermanFunc(m - 1, 1);
    }
    else
    {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
}
int m = 2;
int n = 3;
int result = AckermanFunc(m, n);
Console.Write($"A({m}, {n}) = {result}");