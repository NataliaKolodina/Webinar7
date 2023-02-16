// Напишите программу, которая заполняет двуменый массив, выводит на экран нечетные элементы на четных местах и находит их сумму
// 8 2 3 7
// 2 2 4 2
// 5 9 6 9
// 1 3 3 4

// 3
// 5
// 8


Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 1, 10);
PrintArray(array);
Console.WriteLine();
CheckElements(array);
Console.WriteLine($"Сумма нужных элементов = {SumElements(array)}");

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

void CheckElements(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                if (inArray[i, j] % 2 != 0)
                {
                    Console.WriteLine($"Нужный элемент: {inArray[i, j]}");
                }
            }
        }
    }
}

int SumElements(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                if (inArray[i, j] % 2 != 0)
                {
                    sum += inArray[i, j];
                }
            }
        }
    }
    return sum;
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
