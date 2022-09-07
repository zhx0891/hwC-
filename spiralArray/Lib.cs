public static class Lib
{
    public static void showMeYourArrrr(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(" " + arr[i, j]);
            }
        }
    }
    public static void moveRight(int x, int y, int[,] arr, int count)
    {


        while ((y < arr.GetLength(1)))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                y++;
            }

        }
        showMeYourArrrr(arr);
        Lib.moveDown(x, y, arr, count);

    }
    public static void moveDown(int x, int y, int[,] arr, int count)
    {
        x++;
        y--;
        System.Console.ReadLine();
        while ((x < arr.GetLength(0)))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                x++;
            }
        }
        showMeYourArrrr(arr);
        moveLeft(x, y, arr, count);
    }
    public static void moveLeft(int x, int y, int[,] arr, int count)
    {
        x--;
        y--;
        System.Console.ReadLine();
        while ((y >= 0))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                y--;
            }
        }
        showMeYourArrrr(arr);

    }
    public static void moveUp(int x, int y, int[,] arr, int count)
    {
        System.Console.ReadLine();
        while ((x >= 0))
        {
            if (arr[x, y] == 0)
            {
                arr[x, y] = count;
                count++;
                y--;
            }
        }
        showMeYourArrrr(arr);
    }


}
