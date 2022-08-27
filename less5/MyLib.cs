using System.Text;
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

    public static int[] giveMeBinArray(int num)
    {
        int[] arr = new int[num];
        Random ran = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ran.Next(0, 2);
            System.Console.Write(arr[i] + " ");
        }
        return arr;


    }

    public static int giveMeDigitalNum(string strBinNum)
    {
        int digNum = 0;
        int ind = strBinNum.Length;

        for (int i = 0; i < ind; i++)
        {

            if ((Convert.ToInt32(strBinNum[i]) == 49))
            {
                digNum = digNum + numToStep(2, (ind - i));
            }

        }
        return digNum;
    }

    // public static string arrayToString(string [] arr)
    // {
    //     StringBuilder str = 
    //     for(int i=0; i < arr.Length ; i++)
    //     {
    //         System.Console.Write(arr[i]);
    //     }
    // }


    public static void giveMeNumSys(string digNum, int ss)
    {

        string[] arr = new string[32];
        int workNum = Convert.ToInt32(digNum);
        int ind = 0;

        for (int i = 0; workNum > 0; i++)
        {
            arr[i] = Convert.ToString(workNum % ss);
            workNum = workNum / ss;
            ind = i;
        }

        Array.Resize(ref arr, ind + 1);
        Array.Reverse(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.Write(arr[i]);
        }
        //     StringBuilder str = new();
        //     for (int i = 0; i < arr.Length ; i++)
        //     {
        //         str[i]=Convert .ToChar(arr[i]);
        //     }
        // return str;
    }

    public static int[] giveFullIntArray(int numSize, int arrLength)
    {
        int[] workArr = new int[arrLength];
        Random rand = new Random();
        int min = numToStep(10, numSize - 1);
        int max = numToStep(10, numSize);

        for (int i = 0; i < arrLength; i++)
        {
            workArr[i] = rand.Next(min, max);
        }
        return workArr;
    }
    public static (double min, double max) sortDoubleArr(int size)
    {
        double[] arr = new double[size];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.NextDouble();
        }
        double max = arr[1];
        double min = arr[1];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max) { max = arr[i]; }
            if (arr[i] < min) { min = arr[i]; }
        }
        return (min, max);

    }

}

