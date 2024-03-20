// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void PrintReversedArray (int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    else
    {
        Console.Write(array[index] + " ");
        PrintReversedArray(array, index - 1);
    }
}

int[] array = { 1, 2, 3, 4, 5, 6 };
PrintReversedArray(array, array.Length - 1);

