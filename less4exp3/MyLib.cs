public static class MyLib
{
    public static int numToStep(int n, int step)
    {
        int incr = n;

        for (int h = 1; h != step; h++)
        {
            n = n * incr;
        }
        return n;
    }

    public static int getIndexes(int num)
    {
        int digit = 10;
        int stp = 1;


        while (num > digit)
        {
            stp++;
            digit = numToStep(10, stp);
        }
        return stp;
    }

    public static int[] intToArray(int num, int count)
    {
        int i, x = 0, y = 0;
        int[] arr = new int[count];
        for (i = (count - 1); i >= 0; i--)
        {
            x++;

            if (i == arr.Length - 1)
            {
                arr[i] = num % (numToStep(10, x));
            }
            else
            {
                y++;
                arr[i] = (num / (numToStep(10, y))) % 10;
            }

        }
        return arr;
    }

    public static int giveMeSummArr(int[] arr)
    {
        int summ = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            summ = summ + arr[i];
        }
        return summ;
    }

    public static void showMeYourArrrr()
    {
        int[] arr = new int[8];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 101);
            System.Console.Write(arr[i] + " ");
        }
    }


}