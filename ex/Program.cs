// 39. Найти произведение пар чисел в одномерном массиве.
// int [] arr = new int [10];
// for (int i = 0; i < arr. Length; i++)
// {
//    arr[i]=i;
//   System.Console.Write(arr[i]+ " ");
// }
// System.Console.ReadLine();
// int leng =arr.Length-1;
// for (int i = 0; i < (arr.Length)/2; i++)
// {
//      System.Console.Write($"{arr[i]  * arr[leng-i]} ");
//      System.Console.ReadLine();
// }

// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int [,] arr = new int [5,5];
for (int i = 0; i < arr.GetLength(0); i++)
{ System.Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    
{
        arr[i,j] = i+j;
        System.Console.Write(arr[i,j]+" ");
    }
}