using System;
using System.Text;		//for StringBuilder
using System.Diagnostics;

class psp
{
public static void Main()
{
Stopwatch sw1=new Stopwatch();
Stopwatch sw2=new Stopwatch();

string s="Hello";
Console.WriteLine(s);
sw1.Start();
for(int i=0;i<1000;i++)
{
s=s+" "+i;
}
sw1.Stop();
Console.WriteLine(s);

StringBuilder sb=new StringBuilder();
Console.WriteLine(sb);
sw2.Start();
for(int i=0;i<1000;i++)
{
sb=sb.Append(i);
}
sw2.Stop();

Console.WriteLine(sb);
Console.WriteLine("________________");
Console.WriteLine("----------------");
Console.WriteLine("Time taken in StringBuilder: "+sw2.ElapsedMilliseconds+" Milliseconds");
Console.WriteLine("Time taken in String: "+sw1.ElapsedMilliseconds+" Milliseconds");

}
}