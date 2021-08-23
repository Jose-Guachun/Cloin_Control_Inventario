using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public class ClsCalculoDatos
    {
        decimal coste;
        decimal pvp;
        decimal iva;
        decimal total;

        public decimal Coste(decimal precio)
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
        public decimal PVP(decimal margen, decimal descuento)
        {
            if (descuento < margen)
            {
                pvp = coste / (1 - (margen / 100));
                descuento = pvp * (descuento / 100);
                pvp = pvp - descuento;
                return decimal.Round(pvp, 2);
            }
            else
            {
                MessageBox.Show("El descuento debe de ser menor que el Margen de ganancia");
                return 0;
            }
            

        }
        public decimal IVA(decimal pvp)
        {
            iva = (pvp * decimal.Parse("0,12"));
            return decimal.Round(iva, 2);
        }
        public decimal TOTAL()
        {
            total = pvp + iva;
            return decimal.Round(total, 2);
        }
    }
}
