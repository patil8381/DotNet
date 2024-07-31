using System;
class Program
{
public delegate void AddNumsDelegate(int a,int b);		//declaration of delegate
public delegate string SaySomethingDelegate(string str);
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
string str=Program.SaySomething("Hello");
Console.WriteLine(str);

Program.AddNumsDelegate add=new Program.AddNumsDelegate((x,y)=>		//lamda expression
{
Console.WriteLine("Sum : "+(x+y));
});

add(23,33);
add.Invoke(23,34);

Program.SaySomethingDelegate say=new Program.SaySomethingDelegate(Program.SaySomething);
str=say("Delegate");
Console.WriteLine(str);
str=say.Invoke("called");
Console.WriteLine(str);

Program.SaySomethingDelegate s=(str)=>
{
return "Lambda";
};
str=s("Delegate");
Console.WriteLine(str);

}
}