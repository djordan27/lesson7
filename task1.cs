// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
Console.WriteLine("Введите размеры двумерного массива, колонки и строки:");

int getArraySize()
{
    return Convert.ToInt32(Console.ReadLine());
}
double[,] createArray(int columns, int line)
{
    double[,] array = new double[columns, line];
    Console.WriteLine($"columns = {columns}, line = {line}");
    return array;
}
double[,] fillingArray(double[,] array)
{
    Random rnd = new Random();
    double myNumber = 0;
    double number = 0;
    int meaning = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rnd.Next(2) == 1)
            {
                meaning = 1;
            }
            else { meaning = -1; }
            // myNumber = rnd.Next(10);
            // number = rnd.NextDouble();
            array[i, j] = Math.Round(((rnd.Next(10)) * (rnd.NextDouble()) * meaning), 1);
        }
    }
    return array;
}

void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]}: ");
        }
        Console.Write($"{array[i, array.GetLength(1) - 1]}");

    }
}
printArray(fillingArray(createArray(getArraySize(), getArraySize())));