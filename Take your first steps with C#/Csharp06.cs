using System;
namespace dotNetAcademy
{
    public class Csharp06
    {  public static void Main(string [] args)
        {
            //concatening it all
            string firstText = "Hello, Bob! You have";
            int inboxMessages = 3;
            string secondText = "messages in your inbox. The temperature is";
            decimal degreesCelsius = 34.4m;
            var thirdText = "Celsius";
            Console.WriteLine(firstText + " " + inboxMessages + " " + secondText + " " + degreesCelsius+ " " + thirdText);
        }
    }
}