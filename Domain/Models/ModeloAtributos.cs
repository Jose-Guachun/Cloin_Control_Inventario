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
    public class ModeloCategoria : RepositorioMaestro
    {
        private int idCategoria;
        private int n;
        private string categoria;
        private IRepositorioCategoria repositorioCategoria;
        public EntityState estado { private get; set; }
        

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int N { get => n; set => n = value; }
        [Required(ErrorMessage = "El campo Descricpion esta vacio")]
        public string Categoria { get => categoria; set => categoria = value; }


        public ModeloCategoria()
        {
            repositorioCategoria = new RepositorioCategoria();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosCategoria = new TB_CATEGORIA();
                ModeloDatosCategoria.IdCategoria = idCategoria;
                ModeloDatosCategoria.Categoria = categoria;
                switch (estado)
                {
                    case EntityState.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioCategoria.Add(ModeloDatosCategoria);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EntityState.Modificar:
                        repositorioCategoria.Edit(ModeloDatosCategoria);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EntityState.Eliminar:
                        repositorioCategoria.Remove(idCategoria);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "El registro que intenta guardar ya existe";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;

        }
        public List<ModeloCategoria> GetAll()
        {
            var ModeloDatosCategoria = repositorioCategoria.GetAll();
            var listaCategoria = new List<ModeloCategoria>();
            int cont=0;
            foreach (TB_CATEGORIA item in ModeloDatosCategoria)
            {
                if (item.Categoria.ToString()!=" ")
                {
                    cont += 1;
                    listaCategoria.Add(new ModeloCategoria
                    {
                        idCategoria = item.IdCategoria,
                        n = cont,
                        categoria = item.Categoria
                    });
                }
            }
            return listaCategoria;
        }

        public IEnumerable<ModeloCategoria> FindById(string filter)
        {
            return GetAll().FindAll(c => c.Categoria.Contains(filter.ToUpper()) || c.n.ToString().Contains(filter));
        }

    }
    public class ModeloMarca : RepositorioMaestro
    {
        private int idMarca;
        private int n;
        private string marca;
        private IRepositorioMarca repositorioMarca;
        public EntityState estado { private get; set; }


        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int N { get => n; set => n = value; }
        [Required(ErrorMessage = "El campo Descricpion esta vacio")]
        public string Marca { get => marca; set => marca = value; }


        public ModeloMarca()
        {
            repositorioMarca = new RepositorioMarca();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosMarca = new TB_MARCA();
                ModeloDatosMarca.IdMarca = idMarca;
                ModeloDatosMarca.Marca = marca;
                switch (estado)
                {
                    case EntityState.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioMarca.Add(ModeloDatosMarca);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EntityState.Modificar:
                        repositorioMarca.Edit(ModeloDatosMarca);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EntityState.Eliminar:
                        repositorioMarca.Remove(idMarca);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "El registro que intenta guardar ya existe";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;

        }
        public List<ModeloMarca> GetAll()
        {
            var ModeloDatosMarca = repositorioMarca.GetAll();
            var listaMarca = new List<ModeloMarca>();
            int cont = 0;
            foreach (TB_MARCA item in ModeloDatosMarca)
            {
                if (item.Marca.ToString()!=" ")
                {
                    cont += 1;
                    listaMarca.Add(new ModeloMarca
                    {
                        idMarca = item.IdMarca,
                        n = cont,
                        marca = item.Marca
                    });
                }
            }
            return listaMarca;
        }
        public IEnumerable<ModeloMarca> FindById(string filter)
        {
            return GetAll().FindAll(m => m.Marca.Contains(filter.ToUpper()) || m.n.ToString().Contains(filter));
        }

    }
    public class ModeloModelo : RepositorioMaestro
    {
        private int idModelo;
        private int n;
        private int idMarca;
        private string marca;
        private string modelo;
        private IRepositorioModelo repositorioModelo;
        ModeloProducto producto = new ModeloProducto();
        public EntityState estado { private get; set; }

        public int IdModelo { get => idModelo; set => idModelo = value; }
        public int N { get => n; set => n = value; }
        [Required(ErrorMessage = "El campo Marca esta vacio")]
        public int IdMarca { get => idMarca; set => idMarca = value; }
        
        public string Marca { get => marca; set => marca = value; }
        [Required(ErrorMessage = "El campo Descricpion esta vacio")]
        public string Modelo { get => modelo; set => modelo = value; }
       

        public ModeloModelo()
        {
            repositorioModelo = new RepositorioModelo();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosModelo = new TB_MODELO();
                ModeloDatosModelo.IdModelo = idModelo;
                ModeloDatosModelo.IdMarca = idMarca;
                ModeloDatosModelo.Modelo = modelo;
                switch (estado)
                {
                    case EntityState.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioModelo.Add(ModeloDatosModelo);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EntityState.Modificar:
                        repositorioModelo.Edit(ModeloDatosModelo);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EntityState.Eliminar:
                        repositorioModelo.Remove(idModelo);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "El registro que intenta guardar ya existe";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;

        }
        public List<ModeloModelo> GetAll()
        {
            var ModeloDatosModelo = repositorioModelo.GetAll();
            var listaModelo = new List<ModeloModelo>();
            int cont = 0;
            foreach (TB_MODELO item in ModeloDatosModelo)
            {
                cont += 1;
                listaModelo.Add(new ModeloModelo
                {
                    idModelo = item.IdModelo,
                    n = cont,
                    marca = producto.Marcas(item.Marca).ToString(),
                    modelo = item.Modelo
                });
            }
            return listaModelo;
        }
        public IEnumerable<ModeloModelo> FindById(string filter)
        {
            return GetAll().FindAll(m => m.modelo.Contains(filter.ToUpper()) || m.marca.Contains(filter.ToUpper()) || m.n.ToString().Contains(filter));
        }

    }
}
