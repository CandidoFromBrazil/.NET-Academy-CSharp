using System;
namespace dotNetAcademy
{
    public class Csharp25
    {  public static void Main(string [] args)
        {
            /*
            .Net classes and stateful method;
            Making a dice
            */
            Random dice = new Random();
            int roll = dice.Next(1,6);
            Console.WriteLine(roll);
        }
    }
}