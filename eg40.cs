using System;
using System.IO;
class psp
{
public static void Main()
{
string str="Hello this is good.";

File.Create("newfile.data");
File.WriteAllText("newfile.dat",str);
string r=File.ReadAllText("newfile.dat");
Console.WriteLine(r);

File.AppendText("newfile.dat","\nGod is great");
Console.WriteLine(File.ReadAllText("newfile.dat"));
File.Copy("newfile.dat","NewFile.dat");
Console.WriteLine(File.ReadAllText("NewFile.dat"));
File.Delete("newfile.dat");
Console.WriteLine(File.Exists("newfile.dat"));
File.Replace("newFile.dat","This is new file and its contents.");
Console.WriteLine(File.ReadAllText("NewFile.dat"));

}
}