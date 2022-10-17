using System;
namespace dotNetAcademy1
{
    public class Csharp29
    {  public static void Main(string [] args)
        {
            /*
            boolean in stateful(intance) methods
            */
            String message = "The quick brown fox jumps over the lazy dog";
            bool result = message.Contains("dog");
            Console.WriteLine(result);

            if(message.Contains("fox")){
                Console.WriteLine("Whats does the fox say?");
            }
        }
    }
}