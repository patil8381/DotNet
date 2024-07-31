using System;
class aaa
{
private static int x;
static aaa()
{
x=120;
Console.WriteLine("static Constructor, x : "+x);
}
public aaa()
{
Console.WriteLine("Default Constructor");
}
}
class psp
{
public static void Main()
{
aaa a;
Console.WriteLine("great");
a=new aaa();
}
}