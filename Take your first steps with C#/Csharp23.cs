using System;
namespace dotNetAcademy
{
    public class Csharp23
    {  public static void Main(string [] args)
        {
            //increment and decrement values
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            //string + value++, first display, then sum
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            //++value, first sum, then display
            Console.WriteLine("Fourth: " + (++value));
        }
    }
}