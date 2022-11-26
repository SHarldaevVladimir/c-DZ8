// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество стобцов: ");
    int columns = int.Parse(Console.ReadLine()!);
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}
void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
            if (input[i, j] < 10) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[] transformArray(int[,] input)
{
    int[] array = new int[input.GetLength(0)];
    for (var i = 0; i < input.GetLength(0); i++)
        for (var j = 0; j < input.GetLength(1); j++)
        {
            array[i] += input[i, j];
        }
    return array;
}

void questMinElementArray(int[] input)
{
    var min = input[0];
    var rows = 0;
    for (int i = 0; i < input.GetLength(0); i++)
    {
        if (input[i] < min)
        {
            min = input[i];
            rows = i+1;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке: {min} ");
    Console.WriteLine($"Строка с минимальной суммой элементов: {rows} ");
}
int[,] array = CreateArray();
PrintArray(array);
Console.WriteLine();
questMinElementArray(transformArray(array));

