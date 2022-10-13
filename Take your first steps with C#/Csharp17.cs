using System;
namespace dotNetAcademy
{
    public class Csharp17
    {  public static void Main(string [] args)
        {
            //Add parentheses to make our intention clear to the compiler
            string firstName = "Mattew";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
        }
    }
}