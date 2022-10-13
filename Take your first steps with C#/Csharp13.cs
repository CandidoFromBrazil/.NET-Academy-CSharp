using System;
namespace dotNetAcademy
{
    public class Csharp13
    {  public static void Main(string [] args)
        {
            //character escape sequences + verbatim strings + unicode + and string interpolation
            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string engOutPut = "View English output:";
            string interpolationStringENG = $@"c:\Excercise{projectName}\data.txt";
            string interpolationStringRUS = $@"c:\Excercise{projectName}\data.txt";
            string verbatimStringEng = $@"{engOutPut}:
                    {interpolationStringENG}";
            string verbatimStringRus = $@"{russianMessage}:
                    {interpolationStringENG}";
            Console.WriteLine(verbatimStringEng);
            Console.WriteLine(verbatimStringRus);       
        }
    }
}