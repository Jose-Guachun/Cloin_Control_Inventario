    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//importaciones realizadas por mi
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class RepositorioProveedor : RepositorioMaestro, IRepositorioProveedor
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioProveedor()
        {
            selectAll = "SELECT IdProveedor,P.IdTipoDoc, Tipo, Nombre, Documento, Pais, Direccion, Telefono, Nombre_Operador, Celular, E_mail, Descripcion FROM TB_PROVEEDOR P, TB_TIPO_DOC T where T.IdTipoDoc=P.IdTipoDoc";
            insert = "insert into TB_PROVEEDOR values(@IdTipoDoc,@Nombre, @Documento, @Pais, @Direccion, @Telefono,@Nombre_Operador, @Celular, @E_mail, @Descripcion)";
            update = "update TB_PROVEEDOR set IdTipoDoc=@IdTipoDoc,Nombre=@Nombre,Documento=@Documento, Pais=@Pais, Direccion=@Direccion, Telefono=@Telefono,Nombre_Operador=@Nombre_Operador, Celular=@Celular, E_mail=@E_mail, Descripcion=@Descripcion  where IdProveedor=@IdProveedor";
            delete = "delete from TB_PROVEEDOR WHERE IdProveedor=@IdProveedor";
        }
        public int Add(TB_PROVEEDOR entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdTipoDoc", entity.IdTipoDoc));
            parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@Documento", entity.Documento));
            parameters.Add(new SqlParameter("@Pais", entity.Pais));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Telefono", entity.Telefono));
            parameters.Add(new SqlParameter("@Nombre_Operador", entity.NombreOperador));
            parameters.Add(new SqlParameter("@Celular", entity.Celular));
            parameters.Add(new SqlParameter("@E_mail", entity.Email));
            parameters.Add(new SqlParameter("@Descripcion", entity.Descripcion));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);

        }
        public int Edit(TB_PROVEEDOR entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdProveedor", entity.IdProveedor));
            parameters.Add(new SqlParameter("@IdTipoDoc", entity.IdTipoDoc));
            parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@Documento", entity.Documento));
            parameters.Add(new SqlParameter("@Pais", entity.Pais));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Telefono", entity.Telefono));
            parameters.Add(new SqlParameter("@Nombre_Operador", entity.NombreOperador));
            parameters.Add(new SqlParameter("@Celular", entity.Celular));
            parameters.Add(new SqlParameter("@E_mail", entity.Email));
            parameters.Add(new SqlParameter("@Descripcion", entity.Descripcion));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(update);
        }
        public int Remove(int IdProveedor)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdProveedor", IdProveedor));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
        public IEnumerable<TB_PROVEEDOR> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listProveedor = new List<TB_PROVEEDOR>();

            foreach (DataRow item in tableResult.Rows)
            {
                listProveedor.Add(new TB_PROVEEDOR
                {
                    IdProveedor = Convert.ToInt32(item[0]),
                    IdTipoDoc= Convert.ToInt32(item[1]), 
                    Tipo = item[2].ToString(),
                    Nombre = item[3].ToString(),
                    Documento = item[4].ToString(),
                    Pais = item[5].ToString(),
                    Direccion = item[6].ToString(),
                    Telefono = item[7].ToString(),
                    NombreOperador = item[8].ToString(),
                    Celular = item[9].ToString(),
                    Email = item[10].ToString(),
                    Descripcion = item[11].ToString(),
                });
            }
            return listProveedor;
        }
    }
}
