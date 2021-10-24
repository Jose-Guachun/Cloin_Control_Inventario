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
using System.Runtime.CompilerServices;

namespace Domain.Models
{
    public class ModeloProducto : RepositorioMaestro
    {
        private int idProducto;
        private int n;
        private int idMarca;
        private int idModelo;
        private int idCategoria;
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
        public int Id { get => idProducto; set => idProducto = value; }
        public int N { get => n; set => n = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        [Required(ErrorMessage = "El campo Modelo es requerido")]
        public int IdModelo { get => idModelo; set => idModelo = value; }
        [Required(ErrorMessage = "El campo Categoria es requerido")]
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        [Required(ErrorMessage = "Llene todos los campos")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "El codigo SKU no puede formarce si no selecciona una Categoria, Marca y Modelo para completar los 8 digitos")]
        public string SKU { get => codigo_SKU; set => codigo_SKU = value; }
        [Required(ErrorMessage = "El campo codigo UPC del producto es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Codigo UPC solo debe estar conformado por numeros")]
        [StringLength(maximumLength: 12, MinimumLength = 12, ErrorMessage = "El codigo UPC debe de contener 12 digitos")]
        public string Codigo_UPC { get => codigo_UPC; set => codigo_UPC = value; }
        public byte[] Img { get => img; set => img = value; }

        [Required(ErrorMessage = "El campo Titulo es requerido")]
        [StringLength(maximumLength: 200, MinimumLength = 6, ErrorMessage = "El Titulo debe de contener minimo 6 y un maximo de 200 letras")]
        public string Titulo { get => titulo; set => titulo = value; }
        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El campo Cantidad solo debe estar conformado por numeros")]
        public int Cantidad { get => cantidad; set => cantidad = value; }
        [Required(ErrorMessage = "El campo Caracteristicas es requerido")]
        [StringLength(maximumLength: 400, MinimumLength = 12, ErrorMessage = "Las Caracteristicas debe contener un minimo de 12 y un maximo de 400 letras.")]
        public string Caracteristicas { get => caracteristicas; set => caracteristicas = value; }
        [Required(ErrorMessage = "El campo Coste es requerido")]
        public float Coste { get => coste; set => coste = value; }
        [Required(ErrorMessage = "El campo Margen es requerido")]
        public float Margen { get => margen; set => margen = value; }
        [Required(ErrorMessage = "El campo Descuento es requerido")]
        public float Descuento { get => descuento; set => descuento = value; }
        [Required(ErrorMessage = "El campo PVP es requerido")]
        public float Pvp { get => pvp; set => pvp = value; }
        [Required(ErrorMessage = "El campo IVA es requerido")]
        public float Iva { get => iva; set => iva = value; }
        [Required(ErrorMessage = "El campo TOTAL es requerido")]
        public float Total { get => total; set => total = value; }


        public DataTable ListarCategorias()
        {
            return ExecuteReader("ListarCategorias");
        }
        public DataTable ListarMarca()
        {
            return ExecuteReader("ListarMarca");
        }
        public DataTable ListarModelo(string idMarca)
        {
            return ExecuteReader("SELECT IdModelo,Modelo FROM TB_MARCA JOIN TB_MODELO ON TB_MARCA.IdMarca = TB_MODELO.IdMarca where TB_MARCA.IdMarca="+idMarca);
        }
        public string Marcas(string idMarca)
        {
            var tableResult = ExecuteReader("SELECT Marca FROM TB_MARCA WHERE TB_MARCA.IdMarca=" + idMarca);
            string marca = "0";
            foreach (DataRow item in tableResult.Rows)
            {
                marca= item[0].ToString();
            }
            return marca;
        }
        public string Modelos(string idModelo, bool code)
        {
            var tableResult = ExecuteReader("SELECT IdMarca, Modelo FROM TB_MODELO WHERE TB_MODELO.IdModelo=" + idModelo);
            string modelo="0";
            foreach (DataRow item in tableResult.Rows)
            {
                if (code)                                   
                {
                    modelo = item[0].ToString();
                }
                else
                {
                    modelo = item[1].ToString();
                }
                
            }
            return modelo;
        }
        public string Categorias(string idCategoria)
        {
            var tableResult = ExecuteReader("SELECT Categoria FROM TB_CATEGORIA WHERE TB_CATEGORIA.IdCategoria=" + idCategoria);
            string categoria = "0";
            foreach (DataRow item in tableResult.Rows)
            {
                categoria = item[0].ToString();
            }
            return categoria;
        }
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
                ModeloDatosProducto.IdModelo = idModelo;
                ModeloDatosProducto.IdCategoria = idCategoria;
                ModeloDatosProducto.Codigo_SKU = codigo_SKU;
                ModeloDatosProducto.Codigo_UPC = codigo_UPC;
                ModeloDatosProducto.Img = img;
                ModeloDatosProducto.Titulo = titulo;
                ModeloDatosProducto.Cantidad = cantidad;
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
                    mensaje = "Modelo o Codigo UPC ya esta registrado en otro producto";
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
            int cont = 0;
            foreach (TB_PRODUCTO item in ModeloDatosProducto)
            {
                cont += 1;
                listaProducto.Add(new ModeloProducto
                {

                    idProducto = item.IdProducto,
                    n = cont,
                    idMarca = Convert.ToInt32(Modelos(item.Modelo,true)),
                    idModelo = Convert.ToInt32(item.Modelo),
                    idCategoria= Convert.ToInt32(item.Categoria),
                    marca=Marcas(Modelos(item.Modelo, true)).ToString(),
                    modelo = Modelos(item.Modelo,false).ToString(), 
                    categoria=Categorias(item.Categoria).ToString(),
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
            return GetAll().FindAll(p => p.Marca.Contains(filter.ToUpper()) || p.categoria.Contains(filter.ToUpper()) || p.Modelo.Contains(filter.ToUpper()) || p.codigo_SKU.Contains(filter.ToUpper()) || p.titulo.Contains(filter.ToLower()) || p.n.ToString().Contains(filter));
        }

    }
}
