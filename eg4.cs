class Bulb
{
private int wattage;
public void SetWattage(int w)
{
this.wattage=w;
}
public int GetWattage()
{
return this.wattage;
}
}
class psp
{
public static void Main()
{
Bulb b=new Bulb();
//Bulb b=new Bulb(12);

}
}