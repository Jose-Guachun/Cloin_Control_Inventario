using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entities
{
    public class TB_PRODUCTO
    {
        public int IdProducto { get; set; }
        public int IdCompra { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdCategoria { get; set; }
        public string NumCompra { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Categoria{ get; set; }
        public string Codigo_SKU { get; set; }
        public string Codigo_UPC { get; set; }
        public byte[] Img { get; set; }
        public string Titulo { get; set; }
        public int Cantidad { get; set; }
        public string Caracteristicas { get; set; }
        public float Coste { get; set; }
        public float Margen { get; set; }
        public float Descuento { get; set; }
        public float PVP { get; set; }
        public float IVA { get; set; }
        public float Total { get; set; }

    }
}
