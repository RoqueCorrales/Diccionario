using ITranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public class Espannol : Itranslate
    {
        private Dictionary<String, String> dic;

        public Espannol()
        {
            dic = new Dictionary<string, string>();

            dic.Add("btnBuscar", "Buscar");
            dic.Add("btnAceptar", "OK");
            dic.Add("btnBorrar", "Eliminar");
            dic.Add("btnModificar", " Modificar");
            dic.Add("btnCancelar", "Cancelar");
            dic.Add("lblBienvenida", "Bienvenido");
            dic.Add("lblNombre", "Nombre");
            dic.Add("lblApellido", "Apellido");
            dic.Add("lblCedula", "Cedula");
            dic.Add("lblEntrada", "Inicio");
            dic.Add("lblSalida", "Salida");
            dic.Add("lblGenero", "Genero");
            dic.Add("btnGuardar", "Registrar");
            dic.Add("rbMasculino", "Masculino");
            dic.Add("rbFemenino", "Femenino");
            dic.Add("lblDigitar", "Digitar cedula");
        }
        public string idioma()
        {
            return "Espannol";
        }

        public string translate(string word)
        {
            if (this.dic.ContainsKey(word))
                {
                return dic[word];

            } else
            {
                return "Not found";
            }
        }
    }
}
