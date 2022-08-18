// Console.WriteLine("?");
int a = 111111; //
// int count = 0;
int ind = MyLib.getIndexes(a);
int [] arrNum = new int [ind];
arrNum = MyLib.intToArray(a, ind);
for (int i = arrNum.Length/2; i!=0; i--)
{
    if(arrNum [i]!=arrNum[arrNum.Length^i])
    {
        System.Console.WriteLine(" it's not a palindrome ");
        break ;
    }
    System.Console.WriteLine(" this is palindrome ");
}
