Console.WriteLine("?");
int a = Convert .ToInt32 (Console. ReadLine()); 
int index = MyLib.getIndexes (a); 
int [] num = new int [index]; 
num = MyLib.intToArray(a, index);
System.Console.WriteLine(MyLib .giveMeSummArr(num ));
