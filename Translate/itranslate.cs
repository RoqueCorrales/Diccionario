using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITranslate
{
    public interface Itranslate
    {
        string idioma();
      
        string translate(string word);
   }
}
