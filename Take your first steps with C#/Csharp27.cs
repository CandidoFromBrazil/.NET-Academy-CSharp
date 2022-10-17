using System;
namespace dotNetAcademy1
{
    public class Csharp27
    {  public static void Main(string [] args)
        {
            /*
            getting the lmaximum number with the Math.Max() method
            */
            int firstValue = 500;
            int secondValue = 600;
            int largestValue;
            largestValue = Math.Max(firstValue,secondValue);
            Console.WriteLine(largestValue);
        }
    }
}