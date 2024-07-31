using System;
namespace Abcd
{
class One
{
internal void Test3()
{
Console.WriteLine("Test3");
}
protected internal void Test4()
{
Console.WriteLine("Test4");
}
public void Test5()
{
Console.WriteLine("Test5");
}
}
}
class psp
{
public static void Main()
{
Abcd.One a=new Abcd.One();
a.Test3();
a.Test4();
a.Test5();

}
}
