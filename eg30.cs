using System;
class psp
{
public static void Main()
{
int x,y,z;
Console.Write("Enter a number : ");
try
{
x=int.Parse(Console.ReadLine());
Console.Write("Enter another number : ");
y=int.Parse(Console.ReadLine());
z=x/y;
Console.WriteLine("Sum is : "+z);
}
catch(DivideByZeroException d)
{
Console.WriteLine(d.Message);
}
catch(FormatException f)
{
Console.WriteLine(f.Message);
}
catch(Exception e)
{
Console.WriteLine(e.Message);
}
finally
{
Console.WriteLine("Hello dear, I m finlly block executed everytime.");
}
Console.WriteLine("Program ends...");
}
}