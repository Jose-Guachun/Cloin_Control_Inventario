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
        public string Codigo { get; set; }
        public byte[] Img { get; set; }
        public string Titulo { get; set; }
        public int Cantidad { get; set; }
        public string Caracteristicas { get; set; }
        public decimal Precio { get; set; }
        public decimal Coste { get; set; }
        public decimal Margen { get; set; }
        public decimal Descuento { get; set; }
        public decimal PVP { get; set; }
        public float IVA { get; set; }
        public decimal Total { get; set; }

    }
}
