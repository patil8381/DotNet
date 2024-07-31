using System;
class aaa
{
public aaa(int e)
{
Console.WriteLine("Parameterised constructor called");
}
}
class bbb:aaa
{
//following code is written by compiler
public bbb():base(11)	//call to base class constructor from derived class construct6Fr
{
}
}
class psp
{
public static void Main()
{
bbb b;
b=new bbb();
}
}