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
        private string categoria;
        private IRepositorioCategoria repositorioCategoria;
        public EntityState estado { private get; set; }
        

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
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
            foreach (TB_CATEGORIA item in ModeloDatosCategoria)
            {
                listaCategoria.Add(new ModeloCategoria
                {
                    idCategoria = item.IdCategoria,
                    categoria = item.Categoria
                });
            }
            return listaCategoria;
        }

        public IEnumerable<ModeloCategoria> FindById(string filter)
        {
            return GetAll().FindAll(c => c.Categoria.Contains(filter.ToUpper()));
        }

    }
    public class ModeloMarca : RepositorioMaestro
    {

    }
    public class ModeloModelo : RepositorioMaestro
    {

    }
}
