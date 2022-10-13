using System;
namespace dotNetAcademy
{
    public class Csharp12
    {  public static void Main(string [] args)
        {
            string fisrtName = "Mattew";
            string greeting = "Good to see you";
            //string interpolation
            string message = $"{greeting} {fisrtName}";
            Console.WriteLine(message + "!");
            //combined verbatim literals and string interpolation
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }
    }
}