// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int num = new Random().Next(1, 10);
var array = FillArray(num);
Print(array);
Console.Write($"-> {SumPos(array)}");

int SumPos(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}


