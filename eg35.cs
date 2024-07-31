using System;
using System.Threading;

class psp
{
static void Test1()
{
for(int i=0;i<20;i++)
{
Console.WriteLine("Test1 i : "+i+" ");
}
Console.WriteLine();
Console.WriteLine("Test1 Thread exiting");
}
static void Test2()
{
for(int i=0;i<20;i++)
{
Console.WriteLine("Test2 i : "+i+" ");
if(i==10) 
{
Console.WriteLine("Test2 Thread is slepping ");
Thread.Sleep(5000);
Console.WriteLine("Test2 Thread woke up");
}
}
Console.WriteLine();
Console.WriteLine("Test2 Thread exiting");
}
static void Test3()
{
for(int i=0;i<20;i++)
{
Console.WriteLine("Test3 i : "+i+" ");
}
Console.WriteLine();
Console.WriteLine("Test3 Thread exiting");
}


public static void Main()
{
Thread T1=new Thread(Test1);
Thread T2=new Thread(Test2);
Thread T3=new Thread(Test3);
T1.Start();
T2.Start();
T3.Start();
Console.WriteLine("Main thread exiting");
}
}