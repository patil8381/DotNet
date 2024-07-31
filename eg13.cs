using System;
class aaa
{
public virtual void Sam()
{
Console.WriteLine("aaa : Sam");
}
}
class bbb:aaa
{
public override void Sam()
{
Console.WriteLine("bbb : Sam");
}
}
class ccc:bbb
{
public override void Sam()
{
Console.WriteLine("ccc : Sam");
}
}
class ddd:ccc
{
public new void Sam()
{
Console.WriteLine("ddd : Sam");		//this will be called when the pointer is of ddd
}
}

class psp
{
public static void Main()
{
aaa a=new aaa();
a.Sam();

aaa b=new bbb();
b.Sam();

aaa c=new ccc();
c.Sam();

aaa a1=new ddd();
a1.Sam();

ddd d=new ddd();
d.Sam();
}
}