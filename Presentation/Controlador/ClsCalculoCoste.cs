using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Presentation
{
    public class ClsCalculoCoste
    {
        public static String cost;
        decimal coste;
        decimal precio;
        int cantidad;
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
                        cantidad=Convert.ToInt32(item);
                        break;
                    case 1:
                        precio = Convert.ToDecimal(item);
                        break;
                    case 2:
                        flete = Convert.ToDecimal(item);
                        break;
                    case 3:
                        gasto1 = Convert.ToDecimal(item);
                        break;
                    case 4:
                        gasto2 = Convert.ToDecimal(item);
                        break;
                    case 5:
                        gasto3 = Convert.ToDecimal(item);
                        break;
                    default:
                        break;
                }
                cont++;
            }

            if (precio!=0)
            {
                decimal PrecIva = (precio * 12 / 100) + precio;
                if (cantidad != 0)
                {
                    decimal costFlete = (flete * 12 / 100) + flete;
                    decimal gastoUnitario = (costFlete + gasto1 + gasto2 + gasto3) / cantidad;
                    coste = PrecIva + gastoUnitario;
                }
                else
                {
                    coste = PrecIva;
                }
            }
            else
            {
                MessageBox.Show("El campo precio tiene que ser mayor a 0 por favor ingrese un numero valido", "Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return decimal.Round(coste, 2);
        }
    }
}
