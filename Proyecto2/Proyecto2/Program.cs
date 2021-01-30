using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resul;

            Console.WriteLine("Digite un número?");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite un segundo número?");
            num2 = int.Parse(Console.ReadLine());

            resul = num1 + num2;

            Console.WriteLine("El resultado de la suma de los dos números es: {0} " , resul );
            Console.ReadKey();
        }
    }
}
