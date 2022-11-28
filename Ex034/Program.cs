// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int num = new Random().Next(1, 10);
var array = FillArray(num);
Print(array);
Console.Write($"-> {CountChetn(array)}");

int CountChetn(int[] array)
{
    int count = 0;
    foreach(int item in array)
    {
        if(item % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
