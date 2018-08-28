using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_y_laboratorio_2
{
    public class Persona
    {
        public string nombre;
        public int dni;
        public static int valorEstatico = 1;

        public/*modificador*/ void/*retorno*/ Mostrar(Persona personaX/*parametros obtenidos*/)/*METODO*/
        {
            Console.WriteLine(personaX.nombre);
            Console.WriteLine(personaX.dni);
        }

    }
}
