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
        string categoria;
        string marca;
        string modelo;

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
        public void PVP(decimal margen, decimal descuento, decimal coste)
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
        public List<string> ListaCalculo(decimal margen, decimal descuento, decimal coste, decimal Total, bool idDato)
        {
            if (idDato)
            {
                if (descuento < margen)
                {
                    PVP(margen, descuento, coste);
                }
                else
                {
                    MessageBox.Show("El descuento debe de ser menor que el Margen de ganancia");
                    descuento = 0;
                    PVP(margen, descuento, coste);
                }
            }
            else
            {
                pvp = decimal.Round(Total / decimal.Parse("1,12"), 2);
                if (pvp>coste)
                {
                    IVA();
                    total = Total;
                }
                else
                {
                    pvp = 0;
                    iva = 0;
                    total = 0;
                    MessageBox.Show("El precio de venta al publico tiene que ser mayor que el coste de compra por favor introdusca un Total de venta mayor ");
                }
                
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
        public string SKU(string skuC, string skuM, string skuMo)
        {

            try
            {
                    categoria = skuC.Substring(0, 1);
                    if (skuC.Substring(skuC.Length - 2, 1) == " ")
                    {
                        categoria = categoria + skuC.Substring(skuC.Length - 3, 1);
                    }
                    else
                    {
                        categoria = skuC.Substring(0, 1) + skuC.Substring(skuC.Length - 2, 1);
                    }

                    marca = skuM.Substring(0, 1);
                    if (skuM.Substring((skuM.Length / 2) - 1, 1) == " ")
                    {
                        marca += skuM.Substring((skuM.Length / 2) - 2, 1);
                    }
                    else
                    {
                        marca += skuM.Substring((skuM.Length / 2) - 1, 1) + skuM.Substring(skuM.Length - 2, 1);
                    }

                    modelo = skuMo.Substring(0, 1);
                    if (skuMo.Substring((skuMo.Length / 2) - 1, 1) == " ")
                    {
                        modelo += skuMo.Substring((skuMo.Length / 2) - 2, 1) + skuMo.Substring(skuMo.Length - 2, 1);

                    }
                    else
                    {
                        modelo += skuMo.Substring((skuMo.Length / 2) - 1, 1) + skuMo.Substring(skuMo.Length - 2, 1);
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos");
            }

            return (categoria + marca + modelo).ToUpper();
        }
    }
}
