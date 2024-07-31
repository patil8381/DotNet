interface aaa
{
void Sam();
}
interface bbb:aaa
{
void Tom();
}
interface ccc
{
void sss();
}
class aab
{
public virtual void jerry()
{
System.Console.WriteLine("aab jerry called");
}
}
class abc:aab,ccc,bbb
{
public void Sam()
{
System.Console.WriteLine("abc sam called");
}
public void Tom()
{
System.Console.WriteLine("abc Tom called");
}
public void sss()
{
System.Console.WriteLine("abc sss called");
}
public override void jerry()
{
System.Console.WriteLine("abc jerry called");
}
}
class psp
{
public static void Main()
{
abc a=new abc();
a.Sam();
a.Tom();
a.sss();
a.jerry();
}
}