// Напишите программу, которая заполняет двуменый массив, выводит на экран нечетные элементы на четных местах и находит их сумму
// Вывод массива с помощью разного цвета


Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, colums, 0, 100);
Print2DArray(array);

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

// void PrintArray(int[,] inArray) // вывод на экран двумерного массива
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

void Print2DArray(int[,] someArray) // вывод на экран двумерного массива, окрашенного по строкам разным цветом
{
    bool flag = true;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        if (flag)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            flag = !flag;
        }
        else
        {
            Console.ResetColor();
            flag = !flag;
        }
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j], 4} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}
