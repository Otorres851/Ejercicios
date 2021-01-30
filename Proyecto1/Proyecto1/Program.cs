using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada,entrada2 = "";

            Console.WriteLine("¿digite su nombre? ");
            entrada = Console.ReadLine();

            Console.WriteLine("¿digite su apellido?");
            entrada2 = Console.ReadLine();

            Console.WriteLine("Tu nombre es : {0} y tu apellido es : {1} ", entrada, entrada2);
            Console.ReadKey();
          
        }
    }
}
