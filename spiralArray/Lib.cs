public static class Lib
{
    public static void showMeYourArrrr(int[,] arr)
    {
        System.Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(" " + arr[i, j]);
            }
        }

    }

    public static void moveRight(int x, int y, int[,] arr, int count, int coil)
    {

        if (count < arr.GetLength(0) * arr.GetLength(1))
        {
            while ((y < arr.GetLength(1) - coil))
            {
                arr[x, y] = count;
                count++;
                y++;
            }
            // showMeYourArrrr(arr);
            // System.Console.WriteLine($"                 count= {count}" );
            Lib.moveDown(x, y, arr, count, coil);
        }
        else
        {
            System.Console.WriteLine("array is full");
            showMeYourArrrr(arr);
        }


    }
    public static void moveDown(int x, int y, int[,] arr, int count, int coil)
    {
        x++;
        y--;
        // System.Console.ReadLine();
        while ((x < arr.GetLength(0) - coil))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                x++;
            }
        }
        // showMeYourArrrr(arr);
        moveLeft(x, y, arr, count, coil);
    }
    public static void moveLeft(int x, int y, int[,] arr, int count, int coil)
    {
        x--;
        y--;
        // System.Console.ReadLine();
        while ((y >= coil))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                y--;
            }
        }
        // showMeYourArrrr(arr);
        moveUp(x, y, arr, count, coil);
    }
    public static void moveUp(int x, int y, int[,] arr, int count, int coil)
    {
        y++;
        x--;
        coil++;
        // System.Console.ReadLine();
        while ((x > coil))
        {
            arr[x, y] = count;
            count++;
            x--;
        }
        moveRight(x, y, arr, count, coil);
        // showMeYourArrrr(arr);
    }


}
