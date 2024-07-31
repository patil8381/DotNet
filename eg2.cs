//static member 
using System;
class Bulb
{
private int wattage;
private static int price;
public void SetWattage(int w)
{
this.wattage=w;
}
public int GetWattage()
{
return this.wattage;
}
public void SetPrice(int p)
{
Bulb.price=p;
}
public int GetPrice()
{
return Bulb.price;
}
}
class psp
{
public static void Main()
{
Bulb b1;
b1=new Bulb();
b1.SetWattage(60);
b1.SetPrice(100);
Console.WriteLine("b1 price : "+b1.GetPrice());
Bulb b2;
b2=new Bulb();
b2.SetWattage(120);
b2.SetPrice(200);
Console.WriteLine("b1 price : "+b2.GetPrice());
Console.WriteLine("b1 price : "+b1.GetPrice());
Console.WriteLine("b1 price : "+b2.GetPrice());

}
}
