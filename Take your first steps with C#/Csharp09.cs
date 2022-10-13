using System;
namespace dotNetAcademy
{
    public class Csharp09
    {  public static void Main(string [] args)
        {
            //generating invoices in both English and Japanese
            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!\n\n");
            //verbatim String Literal
            Console.WriteLine(@"c:\invoices");
            //unicode Escape Characters
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
        }
    }
}