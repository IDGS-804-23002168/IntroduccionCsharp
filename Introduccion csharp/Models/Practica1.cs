using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cal1 = 0;
            int cal2, cal3, resultado;
            string dato1;
            string dato2;
            System.Diagnostics.Debug.WriteLine("Tadeo gei");

            Console.WriteLine("Ingresa cal 1: ");
            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);

            Console.WriteLine("Ingresa cal 2: ");
            dato2 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato2);

            resultado = cal1 + cal2;
            Console.WriteLine("El resultado es: " + resultado);

            if (cal1 > cal2)
            {
                Console.WriteLine("La nota mayor es: " + cal1);
            }
            else
            {
                Console.WriteLine("La nota mayor es: " + cal2);
            }

            int x;
            x = 1;

            while (x <= 100)
            {
                Console.Write(x);
                if(x<100)
                Console.Write(" - ");
                x++;                
            }

            Console.Write("\n");
            Console.Write("\n");



            int y = 1;
            do
            {
                Console.Write(y);
                if (y < 100)
                    Console.Write(" - ");
                y++;                

            } while (y <= 100);


            Console.Write("\n");
            Console.Write("\n");

            int f;
            for (f = 1; f <= 100; f++)
            {
                Console.Write(f);
                if (f < 100)
                    Console.Write(" - ");
                
            }

            Console.Write("\n");
            Console.Write("\n");

        }
    }
}
