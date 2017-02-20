using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Clases
{
   public class LogicaPersona : Persona
    {

        public LogicaPersona()
        {

        }
        Persona p = new Persona();

        List<Persona> personas = new List<Persona>();

        public void agregarPersona(Persona p)
        {
            personas.Add(p);
        }

        public List<Persona> listaPersonas()
        {
            return personas;
        }

        public void removerPersona(Persona p)
        {
            foreach (Persona per in personas)
            {
                if (p.cedula.Equals(per.cedula))
                {
                    personas.Remove(per);
                    break;
                }
            }
        }
        public Persona llenarDatos(string persona)
        {
            string[] lista = persona.Split(' ');
            Persona p = new Persona();
            p.nombre = lista[1];
            p.apellido = lista[3];
            p.cedula = lista[5];
            p.genero = lista[7];
            


            return p;


        }


        public void buscarPersona(string persona)
        {
            
            foreach (Persona per in personas)
            {
                if (llenarDatos(persona).cedula.Equals(per.cedula))
                {
                    personas.Remove(per);
                    break;
                }


            }
           
        }

        public void eliminarPersona(string ced)
        {

            foreach (Persona per in personas)
            {
                if (ced.Equals(per.cedula))
                {
                    personas.Remove(per);
                    break;
                }


            }

        }


        public Persona buscadorPorCedula(string cedula)
        {
            foreach (Persona per in personas)
            {
                if (per.cedula.Equals(cedula))
                {
                    return per;
                }
            }
            return null;
        }

    }
}
