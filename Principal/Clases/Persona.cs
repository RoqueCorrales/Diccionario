using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
    public class Persona
    {
        public Persona()
        {

        }
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string apellido { get; set; }
        public string genero { get; set; }

        public DateTime horaEntrada { get; set; }

        public DateTime horaSalida { get; set; }

       

        


        public override string ToString()
        {
            return "Nombre " + nombre +
                " Apellido " + apellido +
                " Cedula " + cedula +
                " Genero " + genero;
        }
    }

}
