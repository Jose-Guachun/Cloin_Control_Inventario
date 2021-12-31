using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Repositories;
using DataAccess.Entities;
using DataAccess.Contracts;
using Domain.ValueObjects;
using System.Data;

namespace Domain.Models
{
    public class ModeloProveedor:RepositorioMaestro
    {
        private int idProveedor;
        private int n;
        private int idTipoDoc;
        private string nombre;
        private string tipo;
        private string documento;
        private string pais;
        private string direccion;
        private string telefono;
        private string operador;
        private string celular;
        private string email;
        private string descripcion;
        private IRepositorioProveedor repositorioProveedor;
        public EntityState estado { private get; set; }
        private List<ModeloProveedor> ListaProveedor;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int N { get => n; set => n = value; }
        public int IdTipoDoc { get => idTipoDoc; set => idTipoDoc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Operador { get => operador; set => operador = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


        public DataTable ListarTipoDoc()
        {
            return ExecuteReader("ListarTipoDoc");
        }
        public ModeloProveedor()
        {
            repositorioProveedor = new RepositorioProveedor();
        }
        public string Guardar()
        {
            string mensaje = null;
            try
            {
                var ModeloDatosProveedor = new TB_PROVEEDOR();
                ModeloDatosProveedor.IdProveedor = idProveedor;
                ModeloDatosProveedor.IdTipoDoc = idTipoDoc;
                ModeloDatosProveedor.Nombre = nombre;
                ModeloDatosProveedor.Documento = documento;
                ModeloDatosProveedor.Pais = pais;
                ModeloDatosProveedor.Direccion = direccion;
                ModeloDatosProveedor.Telefono = telefono;
                ModeloDatosProveedor.NombreOperador = operador;
                ModeloDatosProveedor.Celular= celular;
                ModeloDatosProveedor.Email = email;
                ModeloDatosProveedor.Descripcion = descripcion;
                switch (estado)
                {
                    case EntityState.Agregar:
                        //ejecutar reglas comerciales/calculos
                        repositorioProveedor.Add(ModeloDatosProveedor);
                        mensaje = "Se a registrado Correctamente";
                        break;
                    case EntityState.Modificar:
                        repositorioProveedor.Edit(ModeloDatosProveedor);
                        mensaje = "Se a editado correctamente";
                        break;
                    case EntityState.Eliminar:
                        repositorioProveedor.Remove(idProveedor);
                        mensaje = "Se a Eliminado correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    mensaje = "Llene todos lo campos";
                }
                else
                    mensaje = ex.ToString();
            }
            return mensaje;

        }

        public List<ModeloProveedor> GetAll()
        {
            var ModeloDatosProveedor = repositorioProveedor.GetAll();
            var listaProveedor = new List<ModeloProveedor>();
            int cont = 0;
            foreach (TB_PROVEEDOR item in ModeloDatosProveedor)
            {
                cont += 1;
                listaProveedor.Add(new ModeloProveedor
                {

                    idProveedor = item.IdProveedor,
                    N = cont,
                    idTipoDoc = Convert.ToInt32(item.IdTipoDoc),
                    nombre = item.Nombre,
                    tipo = item.Tipo,
                    documento = item.Documento,
                    pais = item.Pais,
                    direccion = item.Direccion,
                    telefono = item.Telefono,
                    operador= item.NombreOperador,
                    celular = item.Celular,
                    email = item.Email,
                    descripcion = item.Descripcion,
                });
            }

            return listaProveedor;
        }

    }
}
