using System;

namespace firstapp
{
    class Switch
    {
       public static void CallmeSwitch()
        {
           string continent="EUROPE";

           switch(continent){
              case "ASIA":
                      Console.WriteLine("INDIA is one of the countries");  
                      break;
              case "EUROPE":
                      Console.WriteLine("GERMANY is one of the countries");
                      break;
              case "AFRICA":
                      Console.WriteLine("EGYPT is one of the countries"); 
                      break;
              default:
                      Console.WriteLine("SOME COUNTRY");
                      break;
           }
        }
    }
}
