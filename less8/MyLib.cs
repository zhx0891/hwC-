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
    public static (double min, double max) giveMeMinMaxDoubleArr(int size)
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


    public static int countMyNumGreaterZero(int M)
    {
        int workNum = 0;
        int count = 0;
        for (int i = 0; i < M; i++)
        {
            System.Console.WriteLine("Введите число ");
            workNum = Convert.ToInt32(Console.ReadLine());
            if (workNum > 0) { count++; }
        }
        return count;
    }

    public static (double x, double y, double[] arr) pointIntersectionLines(double k1, double k2, double b1, double b2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * x) + b1;
        double[] arr = new double[2];
        arr[0] = x;
        arr[1] = y;
        return (x, y, arr);
    }

    public static double[,] giveMeFullTwoDimensionalArray(int m, int n)
    {
        double[,] workArr = new double[m, n];
        Random rand = new Random();

        for (int i = 0; i < workArr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < workArr.GetLength(1); j++)
            {
                workArr[i, j] = Math.Round(rand.NextDouble() * 9, 0);
                System.Console.Write($" {workArr[i, j]}");
            }
        }
        return workArr;

    }
    public static double[] arithmeticMean(int[,] arr)
    {
        int rows = arr.GetLength(1);
        double[] arithMean = new double[rows];

        for (int i = 0; i < arr.GetLength(1); i++)
        {
            double summ = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                summ = summ + arr[j, i];
            }
            arithMean[i] = summ / arr.GetLength(0);
        }



        return arithMean;
    }
    public static int[,] convDoubleToIntArr(double[,] arr)
    {
        int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result[i, j] = Convert.ToInt32(arr[i, j]);
            }
        }
        return result;
    }
    public static double[] sortLine(double[] arr)
    {

        double max;

        for (int i = 0; i < arr.Length; i++)
        {
            max = 0;
            for (int j = i; j < arr.Length; j++)
            {
                if (max < arr[j])
                {
                    double tmp = max;
                    max = arr[j];
                    arr[j] = tmp;
                }
            }
            arr[i] = max;

            System.Console.Write($" {arr[i]}");

        }
        return arr;
    }

    public static double[,] sortLineDoubleArrayUptoDown(double[,] arr)
    {
        double[] arrSecond = new double[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arrSecond[j] = arr[i, j];
            }
            arrSecond = sortLine(arrSecond);
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = arrSecond[j];
            }

        }
        return arr;
    }
    public static void hideIt(string a)
    {
        System.Console.WriteLine();
        System.Console.WriteLine(a);
        Console.ReadLine();
        System.Console.WriteLine();
    }

    public static double[] giveMeLineSumArr(double[,] arr)
    {
        double[] arrSumm = new double[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            double lineSum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                lineSum = lineSum + arr[i, j];
            }
            arrSumm[i] = lineSum;

        }
        return arrSumm;
    }

    public static double[,] multiplicationArray(double[,] arr, double[,] arr1)
    {
        double[,] resArr = new double[3,3];
        if (arr.GetLength(1) != arr1.GetLength(0))
        {
            System.Console.WriteLine("Эти массивы\\матрицы не согласованы, их произведение невозможно.");
        }
        else
        {
            
            for (int i = 0; i < resArr.GetLength(0); i++)  //строка первой матрицы
            {
                System.Console.WriteLine();
                for (int j = 0; j < resArr .GetLength(1); i++)
                {
                    resArr[i, j] = (arr[i, 0] * arr1[0, i]) + (arr[i, 1] * arr1[1, i]);
                    System.Console.Write(resArr[i, j] + " ");
                }
            }
        }
        return resArr;
    }
}

