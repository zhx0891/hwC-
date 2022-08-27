﻿System.Console.WriteLine("Задача 1. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами. Нажмите ENTER");
Console.ReadLine();
double[,] exmArr = new double[5, 5];
exmArr = MyLib.giveMeFullTwoDimensionalArray(5, 5);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Нажмите ENTER");
Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Выберите  строку ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите  столбец ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

if ((m > exmArr.GetLength(0) || (m < 0)) || ((n > exmArr.GetLength(1)) || (n < 0)))
{
    System.Console.WriteLine("Такой позиции в этом массиве нет");
}
else
{
    System.Console.WriteLine($" Число в данной позиции  - {exmArr[m - 1, n - 1]}");
}
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Нажмите ENTER");
Console.ReadLine();
Console.WriteLine();

double [] exmArr3 = new double[exmArr.GetLength(1)];

exmArr3 = MyLib.arithmeticMean(MyLib .convDoubleToIntArr (exmArr));

for (int i = 0; i < exmArr3.Length; i++)
{
    System.Console.Write($" {exmArr3[i]}");
}