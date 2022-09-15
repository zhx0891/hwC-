var rand = new Random();
int [,] arr = new int [5,5];
for (int i = 0; i < arr.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j]=rand .Next(0,10);
        System.Console.Write(arr[i,j]+ " ");
    }
}