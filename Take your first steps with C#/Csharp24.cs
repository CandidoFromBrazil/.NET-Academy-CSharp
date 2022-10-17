using System;
namespace dotNetAcademy
{
    public class Csharp24
    {  public static void Main(string [] args)
        {
            //calculating Celsius
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m/9m);
            Console.WriteLine("The temperature is "+celsius+"celsius");
        }
    }
}