// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// // 8 4 4 2

int[,] array = CreateArray();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный вариант:");
sortingArray(array);
PrintArray(array);

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

int[,] sortingArray(int[,] input)
{
    int t = 0;
          for (var i = 0; i < input.GetLength(0); i++)
            for (var m = 0; m < input.GetLength(1); m++)
                for (var j = 0; j < input.GetLength(1); j++)
                    if (input[i, m] < input[i, j])
                    {
                        t = input[i, m];
                        input[i, m] = input[i, j];
                        input[i, j] = t;
                    }
    return input;

}

