using System;
using System.Threading;

class psp
{
public static void Main()
{
Thread t=Thread.CurrentThread;
t.Name="Main Thread";
Console.WriteLine(Thread.CurrentThread.Name);


}
}