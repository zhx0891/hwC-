public static class Elements
{
    public static int[,] giveMeFullArr()
    {
        var rand = new Random();
        int[,] arr = new int[5, 5];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = rand.Next(10, 100);
                System.Console.Write(arr[i, j] + " ");
            }
        }
        return arr;
    }

    public static void showArr(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(arr[i, j] + " ");
            }
        }
    }

    public static int[,] replaceStrToRows(int[,] arr)
    {
        int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
        if (arr.GetLength(0) == arr.GetLength(1))
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[j, i] = arr[i, j];
                }
            }


            return arr2;
        }
        else
        {
            System.Console.WriteLine(" этот массив невозможно переверуть");
        }
        return arr;
    }
    public static (int minX, int minY, int min) giveMeMin(int[,] arr)
    {
        int minX = 0;
        int minY = 0;
        int min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    minX = i;
                    minY = j;
                }
            }

        }
        return (minX, minY, min);
    }
}