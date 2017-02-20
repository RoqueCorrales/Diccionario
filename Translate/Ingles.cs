using ITranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
   public class Ingles : Itranslate
 {
        private Dictionary<String, String> dic;
        public Ingles()
        {
            this.dic = new Dictionary<string, string>();
            dic.Add("btnBuscar", "Serch");
            dic.Add("btnAceptar", "OK");
            dic.Add("btnBorrar", "Delete");
            dic.Add("btnModificar", " Rename");
            dic.Add("btnCancelar", "Cancel");
            dic.Add("lblBuscar", "Serch");
            dic.Add("lblNombre", "Name");
            dic.Add("lblApellido", "LastName");
            dic.Add("lblCedula", "ID");
            dic.Add("lblEntrada", "Start");
            dic.Add("lblSalida", "Finish");
            dic.Add("lblBienvenida", "Welcome");
            dic.Add("lblGenero", "Gender");
            dic.Add("btnGuardar", "Register");
            dic.Add("rbMasculino", "Male");
            dic.Add("rbFemenino", "Female");
            dic.Add("lblDigitar", "Type ID");

        }
        public string idioma()
        {
            return "Ingles";
        }

        public string translate(string word)
        {
            if (dic.ContainsKey(word))
            {
                return dic[word];

            }else
            {
                return "Not found";
            }
            
        }
    }
}
