// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int [,] array () {
    int [,]myArray = new int[,] {
        {1, 4, 7, 2,},
        {5, 9, 2, 3,},
        {8, 4, 2, 4,},
    };
    return myArray;
}

void arithmeticMean(int [,] array) {
    double number = 0;
    int size = array.GetLength(1) - 1;
    //Сonsole.WriteLine(size);
    double [] mean = new double [size];
    Console.Write("Средне арифмитическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            number = number + array[j,i];
            //Console.WriteLine(array[j,i]);
        }
         
        if(i < size) {
        mean[i] = (number / size);
        Console.Write(Convert.ToString(mean[i]).Substring(0,3)  + "; ");
        } else {
        mean[size - 1] = Math.Round((number / size), 1);
           Console.Write(mean[size - 1]+ "."); 
        }
        number = 0;
    }
}

arithmeticMean(array());