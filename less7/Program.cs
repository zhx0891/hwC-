System.Console.WriteLine("Задача 1. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами. Нажмите ENTER");
Console.ReadLine();
double[,] exmArr = new double[5, 5];
exmArr = MyLib.giveMeFullTwoDimensionalArray(5, 5);
System.Console.WriteLine();

System.Console.WriteLine("Задача 2. Задайте двумерный массив размером m на n, заполненный случайными вещественными числами. Нажмите ENTER");
Console.ReadLine();
Console.WriteLine();


Console.WriteLine("Веберите  строку ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веберите  столбец ");
int n = Convert.ToInt32(Console.ReadLine());

if ((m > exmArr.GetLength(0)||(m < 0)) || ((n > exmArr.GetLength(1))||(n<0)))
{
    System.Console.WriteLine("Такой позиции в этом массиве нет");
}
else
{
    System.Console.WriteLine(exmArr[m-1, n-1]);
}