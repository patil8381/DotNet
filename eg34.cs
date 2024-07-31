using System;
using System.Threading;

class psp
{
static void Test1()
{
for(int i=0;i<20;i++)
{
Console.Write("Test1 i : "+i+" ");
}
Console.WriteLine();
}
static void Test2()
{
for(int i=0;i<20;i++)
{
Console.Write("Test2 i : "+i+" ");
if(i==10) 
{
Console.WriteLine("thread is slepping ");
Thread.Sleep(5000);
Console.WriteLine("Thread woke up");
}
}
Console.WriteLine();
}
static void Test3()
{
for(int i=0;i<20;i++)
{
Console.Write("Test3 i : "+i+" ");
}
Console.WriteLine();
}


public static void Main()
{
Test1();
Test2();
Test3();
Console.WriteLine("Main thread exiting");

}
}