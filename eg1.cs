class Rectangle
{
private int length;
private int breadth;
public void SetLength(int length)
{
this.length=length;
}
public int GetLength()
{
return this.length;
}
public void SetBreadth(int breadth)
{
this.breadth=breadth;
}
public int GetBreadth()
{
return breadth;
}
}
class Box:Rectangle
{
private int height;
public void SetHeight(int height)
{
this.height=height;
}
public int GetHeight()
{
return height;
}
}
class psp
{
public static void Main()
{
Box b;
b=new Box();
b.SetLength(10);
b.SetHeight(20);
b.SetBreadth(30);
System.Console.Write(b.GetLength());
System.Console.WriteLine(b.GetHeight());
System.Console.Write(b.GetBreadth());

}
}