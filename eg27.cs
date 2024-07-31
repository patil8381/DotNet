using System;

class PredifinedDelegates
{
public double Sam(int x,float y,double z)
{
Console.WriteLine("Sam got called");
return (x+y+z);
}
public void Sammy(int x,int y,double z)
{
Console.WriteLine("Sammy got called");
Console.WriteLine(x+y+z);
}
public bool Tom(string str)
{
Console.WriteLine("Tom got called");
if(str.Length>4) return true;
return false;
}
}
class psp
{
public static void Main()
{
PredifinedDelegates p=new PredifinedDelegates();
Func<int,float,double,double> f=p.Sam;
double d=f(12,14.14f,55.55);
Console.WriteLine(d);

Action<int,int,double> a=p.Sammy;
a(12,14,55.55);

Predicate<string> pr=p.Tom;
bool result=pr("hello");
Console.WriteLine(result);
}
}