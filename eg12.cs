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


}
}