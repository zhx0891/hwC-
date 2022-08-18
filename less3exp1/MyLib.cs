public static class MyLib
{
    public static string checkPalindrom(int[] arr)
    {
        string str;
        for (int i = (arr.Length / 2) - 1; i >= 0; i--)
        {
            if (arr[i] != arr[arr.Length - (i + 1)])
            {
                str =" it's not a palindrome ";
                return str;
            }
            // else
            // {
            //     if (i == 0)
            //     {
            //         str =" ";
            //         return str;
            //     }
            // }
        }
        str ="this is a palindrome ";
        return str;
    }

    // 1//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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
            // System.Console.Write(arr[i] + " ");
        }
        return arr;
    }


}