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
if(z%2==0) throw new ApplicationException("Even number hai");
Console.WriteLine("Sum is : "+z);
}
catch(DivideByZeroException d)
{
Console.WriteLine("DivideByZeroException catch block executed");
Console.WriteLine(d.Message);
}
catch(FormatException f)
{
Console.WriteLine("FormatException catch block executed");
Console.WriteLine(f.Message);
}
catch(Exception e)
{
Console.WriteLine("Exception catch block executed");
Console.WriteLine(e.Message);	//ApplicationException caught here and message displayed.
}
finally
{
Console.WriteLine("Hello dear, I m finlly block executed everytime.");
}
Console.WriteLine("Program ends...");
}
}