using System;
class aaa
{
readonly private int x=45;
public aaa()
{
Console.WriteLine(x);
x=20;
}
public aaa(int e)
{
x=30;
}
public void Sam()
{
Console.WriteLine(x);
}
}
class psp
{
public static void Main()
{
aaa a=new aaa();
a.Sam();
aaa a2=new aaa(50);
a2.Sam();
}
}