using System;
namespace dotNetAcademy
{
    public class Csharp16
    {  public static void Main(string [] args)
        {
            //Mix data types
            string firstName ="Mattew";
            int firstNumber = 40 + 30;
            string mix =$"Your name is: {firstName}, number {firstNumber}";
            Console.WriteLine($@">>> \\{mix}\\");
        }
    }
}