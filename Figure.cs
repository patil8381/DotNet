abstract class Figure
{
public int length,width,radius;
public const float pi=3.14f;
public abstract double GetArea();
}
class Rectangle:Figure
{
public Rectangle(int length,int width)
{
this.length=length;
this.width=width;
}
public override double GetArea()
{
return length*width;
}
}
class Circle:Figure
{
public Circle(int radius)
{
this.radius=radius;
}
public override double GetArea()
{
return pi*radius*radius;
}
}
class psp
{
public static void Main()
{
Rectangle r=new Rectangle(3,4);
Circle c=new Circle(5);
System.Console.WriteLine("Area of Rectangle : " + r.GetArea());
System.Console.WriteLine("Area of Circle : "+c.GetArea());
}
}