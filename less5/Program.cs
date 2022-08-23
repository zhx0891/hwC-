
// Первая  задача.
int multiple = 0;
int noMultiple = 0;
int[] expOne = new int[24];
expOne = MyLib.giveFullIntArray(3, 24);
for (int i = 0; i < expOne.Length; i++)
{
    if ((expOne[i] % 2) == 0) {multiple = multiple + expOne[i];}
    if ((expOne[i] % 2) != 0) {noMultiple = noMultiple + expOne[i];}
}
System.Console.WriteLine($" сумма кратных чисел в массиве {multiple}");
System.Console.WriteLine($" сумма  не кратных чисел в массиве {noMultiple}");
