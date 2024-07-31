using System;
public delegate void AddNumsDelegate(int a,int b);		//declaration of delegate
public delegate string SaySomethingDelegate(string str);
class Program
{
public void AddNums(int x,int y)
{
Console.WriteLine("Sum : "+(x+y));
}
public static string SaySomething(string str)
{
return str;
}
}
class psp
{
public static void Main()
{
Program p=new Program();
p.AddNums(10,20);
string str=Program.SaySomething("Hello");
Console.WriteLine(str);

AddNumsDelegate add=new AddNumsDelegate(p.AddNums);
add(23,33);
add.Invoke(23,34);
SaySomethingDelegate say=new SaySomethingDelegate(Program.SaySomething);
str=say("Delegate");
Console.WriteLine(str);
str=say.Invoke("called");
Console.WriteLine(str);
}
}