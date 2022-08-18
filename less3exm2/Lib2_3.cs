public static class Lib2_3
{
    public static double[] takeCoordinates()
    {
        double[] arr = new double[3];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        return arr;
    }

    public static double giveMeLength(double [] arr1, double [] arr2 )
{
    return Math .Sqrt((Math .Pow ((arr2[0]-arr1[0]),2))+(Math .Pow ((arr2[1]-arr1[1]),2))+(Math .Pow ((arr2[2]-arr1[2]),2)));
}
}