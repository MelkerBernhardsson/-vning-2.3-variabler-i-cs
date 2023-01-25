using System;
namespace uppgift3
{
    class program
    {
         static void Main(string[]args)
         {
           Console.WriteLine("vad är ditt personliga bästa i längdhopp i centimeter");
           string längdtext = Console.ReadLine();
           float längd = float.Parse(längdtext);
           double diff = 895 - längd;
           Console.WriteLine("du hoppar " + diff + " centimeter kortare än världsrekordet");
        }
    }
}