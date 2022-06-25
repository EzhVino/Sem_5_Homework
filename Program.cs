// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(111, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Задайте размер массива с трехзначными числами:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
ShowArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count ++;
}
Console.WriteLine();
Console.WriteLine("Четных чисел в массиве -> " + count);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}


Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон массива от минимального числа:");
int minnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("к максимальному:");
int maxnum = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minnum, maxnum);
ShowArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i += 2)
{
    sum = sum + array[i];
}

Console.WriteLine();
Console.WriteLine("Сумма чисел на нечетных позициях в массиве = " + sum);