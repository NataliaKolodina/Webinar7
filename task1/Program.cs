// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
// m = 3, n = 4
//  1 4 8 19
//  5 -2 33 -2
//  77 3 8 1

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue) // заполнение двумерного массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // вывод на экран двумерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
