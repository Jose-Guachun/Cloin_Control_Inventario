using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public class ClsCalculoCoste
    {
        decimal coste;
        decimal precio;
        int cantida;
        decimal flete;
        decimal gasto1;
        decimal gasto2;
        decimal gasto3;
        
        public decimal Coste(List<string> datos)
        {
            int cont = 0;
            foreach (var item in datos)
            {
                switch (cont)
                {
                    case 0:
                        if (item!=""&&item!="0")
                        {
                            cantida=Convert.ToInt32(item);
                        }
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
            if (datos.ToString() != "")
            {
                decimal iva = precio * 12 / 100;

                coste = precio + iva;
                return decimal.Round(coste, 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
