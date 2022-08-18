Console.WriteLine("?");
int a = Convert .ToInt32(Console .ReadLine());
int ind = MyLib.getIndexes(a);
int[] arrNum = new int[ind];
arrNum = MyLib.intToArray(a, ind);
System.Console.WriteLine(MyLib .checkPalindrom(arrNum));