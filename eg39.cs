using System;
class psp
{
public static void Main()
{
int x;
int y;
string FirstName;
string LastName;
Console.Write("Enter a number : ");
x=Int32.Parse(Console.ReadLine());
Console.Write("Enter a First Name : ");
FirstName=Console.ReadLine();
Console.Write("Enter another number : ");
y=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a Last Name : ");
LastName=Console.ReadLine();
Console.WriteLine("-------------------------");
Console.WriteLine("sum of numbers is : "+(x+y));
Console.Write(FirstName);
Console.WriteLine(" "+LastName);

}
}