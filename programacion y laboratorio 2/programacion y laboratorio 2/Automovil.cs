using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_y_laboratorio_2
{
    class Automovil
    {
        public Single velocidadActual;
        public static Byte cantidadRuedad = 4;
        public static void MostrarCantidadRuedas()
        {
            Console.Write(Automovil.cantidadRuedad);
        }
        public void acelerar(Single velocidad)
        {
            this.velocidadActual += velocidad;
        }
        /*public void MostrarVelocidadActual()
        {
            Console.Write(velocidadActual);
        }*/
    }
}
