using System;
abstract class aaa
{
public abstract void Tom();
public virtual  void Sam()
{
Console.WriteLine("aaa Sam called");
}
}
class bbb:aaa
{
public override void Tom()
{
Console.WriteLine("bbb Tom called");
}
public override void Sam()
{
Console.WriteLine("bbb Sam called");
}
}
class ccc:bbb
{
public override void Tom()
{
Console.WriteLine("ccc Tom called");
}
public override void Sam()
{
Console.WriteLine("ccc Sam called");
}

}
class psp
{
public static void Main()
{
aaa a;
a=new bbb();
a.Sam();
a.Tom();
a=new ccc();
a.Sam();
a.Tom();
}
}