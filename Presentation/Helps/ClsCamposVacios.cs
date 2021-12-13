using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation 
{
    public class ClsCamposVacios
    {
       public string CampoVacio(string campo,string dato)
        {
            if (dato == "")
            {
                dato = "0";
            }
            return dato;
        }
    }
}
