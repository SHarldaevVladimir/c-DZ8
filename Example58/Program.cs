// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// // 
int[,] createArray()
{
    int[,] input = new int[2,2];
    for (int i = 0; i <2; i++)
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Введите элемент [{i},{j}] = ");
        input[i,j] = int.Parse(Console.ReadLine()!);
    }
        
    return input;
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
int [,] productMatrix(int [,] input, int [,]array)
{
    int [,] matrix = new int [2,2];
    matrix[0,0] = input[0,0]*array[0,0]+input[0,1]*array[1,0];
    matrix[0,1] = input[0,0]*array[0,1]+input[0,1]*array[1,1];
    matrix[1,0] = input[1,0]*array[0,0]+input[1,1]*array[1,0];
    matrix[1,1] = input[1,0]*array[0,1]+input[1,1]*array[1,1];
return matrix;
}
Console.WriteLine("Первая Матрица:");
int[,] matrix1 = createArray();
PrintArray(matrix1);
Console.WriteLine("_______________");
Console.WriteLine("Вторая матрица");
int[,] matrix2 = createArray();
PrintArray(matrix2);
Console.WriteLine("_______________");
int[,] prodMatrix = productMatrix(matrix1,matrix2);
Console.WriteLine("Произведение матриц");
PrintArray(prodMatrix);

