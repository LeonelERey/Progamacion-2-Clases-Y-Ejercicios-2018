using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numero = new int[9];
            int i;
            bool confirmacion;

            for(i=0;i<10;i++)
            {
                Console.Write("ingrese un numero entre - 100 y 100");
                confirmacion = Validacion.Validar(numero[i], -100, 100);
                while (confirmacion == false)
                {
                    Console.Write("Debe ingresar un numero entre -100 y 100; Reingrese:");
                    numero[i] = Console.Read();
                    confirmacion = Validacion.Validar(numero[i], -100, 100);

                }
            
            }
            

        }
    }
}
