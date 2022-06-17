using System;

namespace firstapp
{
    class Datatypes
    {
       public static void Callme()
        {
            int   a=20;     //4 bytes
            long b=38080234234; //8 bytes
            float c=343.34f;  //4 bytes
            double d=343364456454546.45; // 8 bytes
            bool e=true;          /*1 bit */
            char f='a'; //2 bytes
            string g= "Rahul"; //each char needs 2 bytes;
            Console.WriteLine("a: "+a+", b: "+b+ ", c: "+c+", d: "+d+", e: "+e+", f: "+f+", g: "+g);
        }
    }
}
