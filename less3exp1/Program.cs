// <<<<<<< HEAD
// ﻿ 
// // Console.WriteLine("?");
// // int a =Convert .ToInt32(Console .ReadLine());
// int a = 123456;

// int ind = MyLib.getIndexes(a);
// int [] NumArray = new int [ind];
// NumArray = MyLib.intToArray(a, ind);
// for(int i = ind/2; i>=0; i--)
// {
//     if (NumArray [i]!=NumArray[NumArray .Length ^i])
// {
//     System.Console.WriteLine("это не палиндром ");
// }
// else 
// {
//     System.Console.WriteLine(" это палиндром");
// }
// }

// =======
﻿Console.WriteLine("?");
int a = Convert .ToInt32(Console .ReadLine());
int ind = MyLib.getIndexes(a);
int[] arrNum = new int[ind];
arrNum = MyLib.intToArray(a, ind);
System.Console.WriteLine(MyLib .checkPalindrom(arrNum));
// >>>>>>> 40ebb5cfb30eb7353b50428b6b7f7ffd7206a495
