using System;
namespace dotNetAcademy1
{
    public class Csharp36
    {  public static void Main(string [] args)
        {
            /*
            warehouse
            */
            string[] fraudulentOrders = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
            foreach(string order in fraudulentOrders){
                if(order.StartsWith("B")){
                    Console.WriteLine($"A order that starts with (B) = {order}");
                }
            }
        }
    }
}