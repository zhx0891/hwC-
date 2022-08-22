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
            // System.Console.WriteLine( Convert .ToInt32(strBinNum[i]) );
            if ((Convert.ToInt32(strBinNum[i]) == 49))
            {
                digNum = digNum + numToStep(2, (ind - i));
            }

        }
        return digNum;
    }
    public static String  giveMeNumSys(string digNum, int ss)
    {
        string SysNum ="    test";
        string[] arr = new string [32];
        int workNum = Convert .ToInt32(digNum);
        System.Console.WriteLine(workNum );
        for( int i = 0 ; workNum  > 0; i++)
        {
            arr[i] = Convert .ToString (workNum%ss);
            workNum = workNum /ss;
            System.Console.WriteLine($" значение {arr[i]} индекс {i} ");
        }
        
        
        return SysNum;
    }

}

