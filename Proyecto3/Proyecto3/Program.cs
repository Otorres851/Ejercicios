using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{[
    ]
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resul;

            Console.WriteLine("digite un número");
            num1= int.Parse (Console.ReadLine());

            Console.WriteLine("digite un segundo número");
            num2 = int.Parse(Console.ReadLine());
           
            resul= num1+num2;

            
            if (resul < 10) 
            {
                Console.WriteLine("El resultado de la suma es: {0} y es menor que 10", resul);
            } 
            else if (resul == 10)
            {
                Console.WriteLine("El resultado de la suma es igual a: {0}", resul);
            } 
            else
            {
                Console.WriteLine("El resultado de la suma es: {0} y es mayor que 10", resul);  
            }
            

           
            Console.ReadKey();

        }
    }
}
