/*
Задача 29: Напишите программу, которая приниматет на вход длину массива,
минимальное значение массива и максимальное значение массива, создаёт массив с заданными параметрами
и выводит значения на экран
5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]
*/

int n, min, max;

Console.Write("Введите длину массива: ");
n = ReadNumberFromConsole();

Console.Write("Введите минимальное значение элемента массива: ");
min = ReadNumberFromConsole();

Console.Write("Введите максимальое значение элемента массива: ");
max = ReadNumberFromConsole();

int[] array = new int[n];

FillArray(array, min, max);

Console.Write($"{n}, {min}, {max} -> ");

PrintArry(array);

int ReadNumberFromConsole()
{
    string? input = Console.ReadLine();
    return int.Parse(input);
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
}

void PrintArry(int[] array)
{
    Console.Write("{");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}