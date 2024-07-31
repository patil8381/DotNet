class CompareName
{
public static void Main()
{
string name1 = "Hari";
string name2 = "Hari";
string name3 = "daas";
string name4 = "HARI";
System.Console.WriteLine(name1.Equals(name2));
System.Console.WriteLine(name1.Equals(name3));
System.Console.WriteLine(name1.Equals(name4));

System.Console.WriteLine(name1.EqualsIgnoreCase(name3));
System.Console.WriteLine(name1.EqualsIgnoreCase(name4));

}
}