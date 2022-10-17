using System;
namespace dotNetAcademy1
{
    public class Csharp33
    {  public static void Main(string [] args)
        {
            /*
            array structure II
            */
            string[] names = new string[3];
            names[0] = "Matheus";
            names[1] = "Willians";
            names[2] = "Candido";
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}