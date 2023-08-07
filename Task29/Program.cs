// Задача 29:
// Напишите программу, которая
// задаёт массив из 8 элементов заполненный псевдослучайными числами
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 –> [1, 2, 5, 7, 19, 6, 1, 33]

void FillingArray(int[] arr, int min, int max)
{
    if (max < min) (max, min) = (min, max);
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
}

void OutputArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write($", {arr[i]}");
    }
    Console.Write(" ]");
}

Console.Write("Введите минимальное значение элементов массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];
FillingArray(array, minValue, maxValue);
Console.Write("Массив: ");
OutputArray(array);
