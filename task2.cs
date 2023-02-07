// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

int [,] array () {
    int [,]myArray = new int[,] {
        {1, 4, 7, 2,},
        {5, 9, 2, 3,},
        {8, 4, 2, 4,},
    };
    return myArray;
}

int getIndex(){
    return Convert.ToInt32(Console.ReadLine());
}

bool existsIndex (int columns, int line, int [,] array) {
 if(array.GetLength(0) > columns && array.GetLength(1) > line) {
    return true;
    }
    else{
    return false; 
    }
}

void printResult (int columns, int line, bool exists, int[,] array) {
    if(exists == true) {
        Console.WriteLine($"пользователь вводит индексы {columns}, {line} - выводим элемент {array[columns, line]}");
    } else {
        Console.WriteLine($"пользователь вводит индексы {columns}, {line} - такого элемента нет.");
    }
}

int myColumns = getIndex();
int myLine = getIndex();
printResult(myColumns,myLine, existsIndex(myColumns,myLine,array()), array());