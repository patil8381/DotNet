using System;
class aaa
{
public void Sam()
{
Console.WriteLine("Great");
}
}
class bbb:aaa
{  
public void Tom()
{
Console.WriteLine("Cool");
}
}
class psp
{
public static void Main()
{
aaa a=new aaa();
a.Sam();
a.Tom();		//error

bbb b=new bbb();
a.Sam();
a.Tom();

aaa a=new bbb();
a.Sam();
a.Tom();		//error 

}
}