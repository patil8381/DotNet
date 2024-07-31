using System;
class Employee
{
int Eno;
string name;
int salary;
public Employee(int Eno,string name,int salary)
{
this.Eno=Eno;
this.name=name;
this.salary=salary;
}
public Object this[int index]
{
get
{
if(index==0) return this.Eno;
else if(index==1) return this.name;
else if(index==2) return this.salary;
return null;
}
set
{
if(index==0) this.Eno=(int)value;
if(index==1) this.name=(string)value;
if(index==2) this.salary=(int)value;
}
}
}
class psp
{
public static void Main()
{
Employee e=new Employee(101,"Raju",200000);
System.Console.WriteLine(e[0]);
System.Console.WriteLine(e[1]);
System.Console.WriteLine(e[2]);

e[0]=23;
e[1]="Kelkar";
System.Console.WriteLine(e[0]);
System.Console.WriteLine(e[1]);

}
}

