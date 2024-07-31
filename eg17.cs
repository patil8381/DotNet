// C# program to illustrate
// the use of Console.ReadLine()
// to pause the console
using System;
using System.IO;

class Geeks {
    
    // Main Method
    public static void Main()
    {
        string name;

        Console.Write("Enter your name: ");
        
        // typecasting not needed as 
        // ReadLine returns string
        name = Console.ReadLine();
        
        Console.WriteLine("Hello " + name + 
             " Welcome to Pro Coding Club!");
        
        // Pauses the console until 
        // the user presses enter key
        Console.ReadLine(); 
    } 
}
