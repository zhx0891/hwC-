using System;
// 39. Найти проведение пар чисел в одномерном массиве.
// double [] arr = new double [10];
// for (double i = 0; i < arr. Length; i++)
// {
//    arr[i]=i;
//   System.Console.Write(arr[i]+ " ");
// }
// System.Console.ReadLine();
// double leng =arr.Length-1;
// for (double i = 0; i < (arr.Length)/2; i++)
// {
//      System.Console.Write($"{arr[i]  * arr[leng-i]} ");
//      System.Console.ReadLine();
// }

// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// double[,] arr = new double[5, 5];

// for (double i = 0; i < arr.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (double j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = i + j;
//         System.Console.Write(arr[i, j] + " ");
//     }
// }
// double [] numFibo = {0,1};
// double count = 30;
// for (double i = 2; i < count; i++)
// {
//    Array .Resize( ref numFibo, numFibo.Length + 1);
//    numFibo[i]=numFibo[i-1]+numFibo[i-2];
// }
// for (double i = 0; i < numFibo.Length; i++)
// {
//     System.Console.Write(numFibo[i]+" ");
// }
//  Выяснить являются ли три числа сторонами треугольника 

// Чтобы определить, являются ли 3 длины сторон треугольником,
//  используйте теорему неравенства треугольника,
//  которая гласит, что сумма 2 сторон треугольника должна быть больше третьей стороны


// double [] arrX = {3, 5, 1};  //координаты x для трёх точек
// double [] arrY = {2, 6, 3};  //координаты y для трёх точек

// // Длинна отрезка d^2= (х2— х1)^2+ (y2— y1)^2
// double lineOne = Math .Sqrt (Math .Pow((arrX[1]-arrX[0]), 2)-Math .Pow((arrY[1]-arrY[0]), 2));
// double lineSecond = Math .Sqrt (Math .Pow((arrX[1]-arrX[2]), 2)-Math .Pow((arrY[1]-arrY[2]), 2));
// double lineThird = Math .Sqrt (Math .Pow((arrX[2]-arrX[0]), 2)-Math .Pow((arrY[2]-arrY[0]), 2));
// // double [] arrPoints = {lineOne,lineSecond,lineThird};
// if(lineOne+lineSecond > lineThird) {System.Console.WriteLine(" да,  это точки одного треугольника");}
// if(lineOne+lineThird > lineSecond) {System.Console.WriteLine(" да,  это точки одного треугольника");}
// if(lineThird+lineSecond > lineOne) {System.Console.WriteLine(" да,  это точки одного треугольника");}
// else{System.Console.WriteLine(" нет эти точки не подходят");}

// 54. В матрице чисел найти сумму элементов главной диагонали

int [,] arr = new int [5,5];
for (int i = 0; i < arr.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       arr[i,j]=i+j;
       System.Console.Write(arr[i,j] + " ");
    }
}
System.Console.WriteLine();
int summ = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    summ=summ+arr[i,i];
}
System.Console.WriteLine(summ);