using System;
namespace dotNetAcademy1
{
    public class Csharp34
    {  public static void Main(string [] args)
        {
            /*
            warehouse
            */
            int[] invetory = {200, 450, 700, 175, 250};
            int sum = 0;
            int bin = 0;
            foreach(int items in invetory){
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in the inventory");
        }
    }
}