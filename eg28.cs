//lamda expression with Func , Action and Predicate 

using System;

class psp
{
public static void Main()
{
Func<int,float,double,double> f=(x,y,z)=>
{
return (x+y+z);
};
double d=f(12,14.14f,55.55);
Console.WriteLine(d);

Action<int,int,double> a=(x,y,z)=>
{
Console.WriteLine(x+y+z);
};
a(12,14,55.55);

Predicate<string> pr=(str)=>
{
if(str.Length>4) return true;
return false;
};
bool result=pr("hello");
Console.WriteLine(result);
}
}