using System;
class Dog
{
public virtual void PrintName()
{
Console.WriteLine("Tommy");
}
}
class GermanShephard:Dog
{
public void Jump()
{
Console.WriteLine("Jump");
}
public new void PrintName()
{
Console.WriteLine("Bruno");
}
}
class psp
{
public static void Main()
{
GermanShephard gs=new GermanShephard();
gs.PrintName();
gs.Jump();

Dog d=new GermanShephard();
d.PrintName();

Dog d2=new Dog();
d2.PrintName();
}
}