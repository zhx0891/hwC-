﻿Console.WriteLine("введите число");
string a = Console .ReadLine();
if (a .Length < 3)
{
    Console.WriteLine("в этом числе нет третьей цифры");
}
else 
{
    Console.WriteLine(a[2]);
}
