// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int num = new Random().Next(1, 10);
var array = FillArray(num);
Print(array);
Console.WriteLine();
//Console.WriteLine(GetMax(array));
//Console.WriteLine(GetMin(array));
var Razn = GetMax(array) - GetMin(array);
Console.Write($"Разница между максимальным и минимальным элементом массива {Razn}");

int GetMax(int[] array)
{
    int max = array[0];
    foreach (var item in array)
    {
        if (item > max)
        {
            max = item;
        }
    }
    return max;
}

int GetMin(int[] array)
{
    int min = array[0];
    foreach (var item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }
    return min;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
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



