var rand = new Random();
int[] dict = new int[10];
int[,] arr = new int[5, 5];
for (int i = 0; i < arr.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rand.Next(0, 10);
        System.Console.Write(arr[i, j] + " ");
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        dict[arr[i, j]] =dict[arr[i, j]] +1;
    }
}
System.Console.WriteLine();

for (int i = 0; i < dict.Length; i++)
{
    System.Console.WriteLine($"Число {i} встречается  {dict[i]}  раз ");
}