using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Importacion
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class RepositorioCategoria : RepositorioMaestro, IRepositorioCategoria
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioCategoria()
        {
            selectAll = "select * from TB_CATEGORIA";
            insert = "insert into TB_CATEGORIA values( @Categoria)";
            update = "update TB_CATEGORIA set  Categoria=@IdCategoria";
            delete = "delete from TB_CATEGORIA WHERE IdCategoria=@IdCategoria";
        }
        //este metodo recive como parametro un metodo que es la entidad TB_PRODUCTO
        public int Add(TB_CATEGORIA entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Categoria", entity.Categoria));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Edit(TB_CATEGORIA entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdCategoria", entity.IdCategoria));
            parameters.Add(new SqlParameter("@Categoria", entity.Categoria));

            return ExecuteNonQuery(update);
        }

        public IEnumerable<TB_CATEGORIA> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listProducto = new List<TB_CATEGORIA>();

            foreach (DataRow item in tableResult.Rows)
            {
                listProducto.Add(new TB_CATEGORIA
                {
                    IdCategoria = Convert.ToInt32(item[0]),
                    Categoria = item[1].ToString()
                });
            }
            return listProducto;
        }
        public int Remove(int IdCategoria)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdCategoria", IdCategoria));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
    class RepositorioMarca
    {
    }
    class RepositorioModelo
    {
    }
}
