class psp
{
public static void Main()
{
int[] x=new int[10];

x[0]=10;
x[1]=20;
x[2]=30;
x[3]=40;
x[4]=50;
for(int i=0;i<10;i++)
{
x[i]=i*i;
}
for(int i=0;i<10;i++)
{
System.Console.WriteLine(x[i]);
}

}
}