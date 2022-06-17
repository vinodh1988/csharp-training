using System;

using System;

namespace firstapp
{
    class Operators
    {
       public static void CheckOps()
        {
            //Console.WriteLine("Hello World!");
           Console.WriteLine("2+3*5 ->"+(2+3*5));
           Console.WriteLine("2%10 ->"+(2%10));
           Console.WriteLine("2>3 ->"+(2>3)); // >, < ,==, !=, >=,<=
           Console.WriteLine("3>2 && 5>=5 ->"+(3>2 && 5>=5));// && || !
           Console.WriteLine("!true " + (!true));
           Console.WriteLine("12>3?'India':'China' ->"+(12>3?"India":"China"));
        }
    }
}