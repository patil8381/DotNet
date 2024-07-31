using System.Collections;
class psp
{
public static void Main()
{
ArrayList list=new ArrayList();
list.Add(10);
list.Add(45);
list.Add(434);
list.Add(34);
foreach(int i in list)
{
System.Console.WriteLine(i);
}
list.Remove(2);
System.Console.WriteLine("Capacity : "+list.Capacity);

foreach(int i in list)
{
System.Console.WriteLine(i);
}

}
}