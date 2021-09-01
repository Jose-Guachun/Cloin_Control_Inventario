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
        decimal desc;

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
        public void PVP(decimal margen, decimal descuento)
        {
            pvp = coste / (1 - (margen / 100));
            desc = pvp * (descuento / 100);
            pvp = decimal.Round(pvp - desc, 2);
            IVA();
            if (descuento == 0)
            {
                total = decimal.Round(pvp + iva);
                pvp = decimal.Round(total / decimal.Parse("1,12"), 2);
                IVA();
            }
            else
            {
                total = decimal.Round(pvp + iva, 2);
            }
        }
        public void IVA()
        {
            iva = (pvp * decimal.Parse("0,12"));
            iva = decimal.Round(iva, 2);
        }
        public List<string> ListaCalculo(decimal margen, decimal descuento){
            if (descuento < margen)
            {
                PVP(margen, descuento);
            }
            else
            {
                MessageBox.Show("El descuento debe de ser menor que el Margen de ganancia");
                descuento = 0;
                PVP(margen, descuento);
            }
            List<string> listCalculo = new List<string>()
        {
            descuento.ToString(),
            pvp.ToString(),
            iva.ToString(),
            total.ToString(),
            
         };
            return listCalculo;
        }
    }
}
