using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int num = 0;*/

            /*while (num < 10) {
                Console.WriteLine("Hola mundo");
                num++;
            }*/

            /*do
            {
                Console.WriteLine("Hola mundo");
                num++;
            } while (num < 10);*/

            /*for (int num = 0; num < 10; num++)
            {
                Console.WriteLine("Hola mundo");
            }*/

            mostrarhola();
            Console.WriteLine(regresarsuma());
            hola2();
            Console.ReadKey();
        }
        
       
          static void mostrarhola () 
        {
         Console.WriteLine("hola");
        }

         static int regresarsuma()
         {
             int suma = 9 + 9;
             return suma;
         }

         static void hola2()
         {
             Console.WriteLine("Hola2");
         }
     }

       
    
}
