using System;

namespace firstapp
{
    class Conditional
    {
       public static void IfDemo()
        {
           int age=45;

           if(age>60)
              {
                Console.WriteLine("Senior Citizen");
              }
           else if(age>40 && age <=60)
              {
                Console.WriteLine("Middle Aged");
              }
           else if(age>18 && age<=40){
                Console.WriteLine("Adult");
           }
           else {
                Console.WriteLine("Juvenile");
           }
        }
    }
}
