using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
//referencias a los repositorios de DataAccess
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System.Data;

namespace Domain.Models
{
    public class ModeloProducto
    {
        private int idProducto;
        private int idCompra;
        private int idMarca;
        private int idModelo;
        private int idCategoria;
        private string numCompra;
        private string marca;
        private string modelo;
        private string categoria;
        private string codigo_SKU;
        private string codigo_UPC;
        private byte[] img;
        private string titulo;
        private int cantidad;
        private string caracteristicas;
        private float  coste;
        private float  margen;
        private float descuento;
        private float  pvp;
        private float iva;
        private float  total;

        private IRepositorioProducto repositorioProducto;
        public EntityState estado { private get; set; }
        private List<ModeloProducto> ListaProducto;

        //propiedades/modelo de vista /validar datos
        public int IdProducto { get => idProducto; set => idProducto = value; }
        [Required(ErrorMessage = "El campo Numero de Compra es requerido")]
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NumCompra { get => numCompra; set => numCompra = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        [Required(ErrorMessage = "El campo codigo SKU del producto es requerido")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "El codigo SKU debe de contener 8 digitos")]
        public string Codigo_SKU { get => codigo_SKU; set => codigo_SKU = value; }
        [Required(ErrorMessage = "El campo codigo UPC del producto es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Codigo UPC solo debe estar conformado por numeros")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "El codigo UPC debe de contener 12 digitos")]
        public string Codigo_UPC { get => codigo_UPC; set => codigo_UPC = value; }
        public byte[] Img { get => img; set => img = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        public float Coste { get => coste; set => coste = value; }
        public float Margen { get => margen; set => margen = value; }
        [Required(ErrorMessage = "El campo Descuento es requerido")]
        public float Descuento { get => descuento; set => descuento = value; }
        public float Pvp { get => pvp; set => pvp = value; }
        public float Iva { get => iva; set => iva = value; }
        public float Total { get => total; set => total = value; }


        public ModeloProducto()
        {
            repositorioProducto = new RepositorioProducto();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosProducto = new TB_PRODUCTO();
                ModeloDatosProducto.IdProducto = idProducto;
                ModeloDatosProducto.IdCompra = idCompra;
                ModeloDatosProducto.IdModelo = idModelo;
                ModeloDatosProducto.IdMarca = idMarca;
                ModeloDatosProducto.IdCategoria = idCategoria;
                ModeloDatosProducto.Codigo_SKU = codigo_SKU;
                ModeloDatosProducto.Codigo_UPC = codigo_UPC;
                ModeloDatosProducto.Img = Img;
                ModeloDatosProducto.Titulo = titulo;
                ModeloDatosProducto.Cantidad = Cantidad;
                ModeloDatosProducto.Caracteristicas = caracteristicas;
                ModeloDatosProducto.Coste = coste;
                ModeloDatosProducto.Margen = margen;
                ModeloDatosProducto.Descuento = descuento;
                ModeloDatosProducto.PVP = pvp;
                ModeloDatosProducto.IVA = iva;
                ModeloDatosProducto.Total = total;
                switch (estado)
                {
                    case EntityState.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioProducto.Add(ModeloDatosProducto);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EntityState.Modificar:
                        repositorioProducto.Edit(ModeloDatosProducto);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EntityState.Eliminar:
                        repositorioProducto.Remove(idProducto);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "Registro Duplicado";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;

        }

        public List<ModeloProducto> GetAll()
        {
            var ModeloDatosProducto = repositorioProducto.GetAll();
            var listaProducto = new List<ModeloProducto>();
            foreach (TB_PRODUCTO item in ModeloDatosProducto)
            {
                listaProducto.Add(new ModeloProducto
                {
                    
                    idProducto = item.IdProducto,
                    numCompra=item.NumCompra,
                    marca=item.Marca,
                    modelo=item.Modelo,
                    categoria=item.Categoria,
                    codigo_SKU=item.Codigo_SKU,
                    codigo_UPC = item.Codigo_UPC,
                    img =item.Img,
                    titulo=item.Titulo,
                    cantidad = item.Cantidad,
                    caracteristicas =item.Caracteristicas,
                    coste=item.Coste,
                    margen =item.Margen,
                    descuento = item.Descuento,
                    pvp = item.PVP,
                    iva = item.IVA,
                    total = item.Total
                });
            }
            return listaProducto;
        }

        public IEnumerable<ModeloProducto> FindById(string filter)
        {
            return GetAll().FindAll(p => p.codigo_SKU.Contains(filter) || p.titulo.Contains(filter));
        }

    }
}
