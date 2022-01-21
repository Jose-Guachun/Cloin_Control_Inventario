using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public class ClsCalculoDatos
    {
        public static ValueType valueCategoria=null;
        public static ValueType valueMarca=null;
        public static ValueType valueModelo=null;
        public static Boolean banderaAt;
        public static Boolean edit=false;
        public static int caso=0;
        decimal pvp;
        decimal marge;
        decimal utilidad;
        decimal iva;
        decimal total;
        decimal desc;
        string categoria;
        string marca;
        string modelo;

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
                    MessageBox.Show("El descuento debe de ser menor que el Margen de ganancia"," Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    descuento = 00;
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
                    pvp = 00;
                    iva = 00;
                    total = 00;
                    MessageBox.Show("El precio de venta al publico tiene que ser mayor que el coste de compra, por favor ingrese un Total valido.", " Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            if (pvp > coste)
            {
                utilidad = pvp - coste;
            }
            
            if (utilidad>0)
            {
                marge = decimal.Round((utilidad / pvp) * 100, 0);
            }

            List<string> listCalculo = new List<string>()
        {
            descuento.ToString(),
            pvp.ToString(),
            iva.ToString(),
            total.ToString(),
            utilidad.ToString(),
            marge.ToString(),

         };
            return listCalculo;
        }
        public string SKU(string skuC, string skuM, string skuMo)
        {
            bool a=true;
            bool b=true;
            try
            {

                categoria = skuC.Substring(0, 1);
                    if (skuC.Substring(skuC.Length - 2, 1) == " ")
                    {
                        categoria += skuC.Substring(skuC.Length - 3, 1);
                    }
                    else
                    {
                        categoria += skuC.Substring(skuC.Length - 2, 1);
                    }

               marca = skuM.Substring(0, 1);
               
                    if (skuM.Substring((skuM.Length / 2) - 1, 1) == " ")
                    {
                        marca += skuM.Substring((skuM.Length / 2) - 2, 1) + skuM.Substring(skuM.Length - 2, 1);
                    }
                    else
                    {
                        marca += skuM.Substring((skuM.Length / 2) - 1, 1) + skuM.Substring(skuM.Length - 2, 1);
                    }

                modelo = skuMo.Substring(0, 1);
                for (int i = 1; i < skuMo.Length; i++)
                {
                    if (a && skuMo.Substring((skuMo.Length / 2)-i, 1) != " " )
                    {
                        modelo += skuMo.Substring((skuMo.Length / 2)-i , 1);
                        a = false;
                    }
                    if (b && skuMo.Substring(skuMo.Length - i-1, 1)!= " ")
                    {
                        modelo += skuMo.Substring(skuMo.Length - i-1, 1);
                        b = false;
                    }
                }
                    
            }
            catch (Exception)
            {
                
            }

            return (categoria + marca + modelo).ToUpper();
        }
    }
}
