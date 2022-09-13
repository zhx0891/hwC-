// 39. Найти произведение пар чисел в одномерном массиве.
int [] arr = new int [10];
for (int i = 0; i < arr. Length; i++)
{
   arr[i]=i;
  System.Console.Write(arr[i]+ " ");
}
System.Console.ReadLine();
int leng =arr.Length-1;
for (int i = 0; i < (arr.Length)/2; i++)
{
     System.Console.Write($"{arr[i]  * arr[leng-i]} ");
     System.Console.ReadLine();
}