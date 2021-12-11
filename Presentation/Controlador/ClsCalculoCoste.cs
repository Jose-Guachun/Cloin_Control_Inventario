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
        public decimal Coste(decimal precio, decimal gastos)
        {
            if (precio.ToString() != "")
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
