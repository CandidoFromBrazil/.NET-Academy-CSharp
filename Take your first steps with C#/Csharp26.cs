using System;
namespace dotNetAcademy1
{
    public class Csharp26
    {  public static void Main(string [] args)
        {
            /*
            overloading the Random.Next() method
            */

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(1,6);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
        }
    }
}