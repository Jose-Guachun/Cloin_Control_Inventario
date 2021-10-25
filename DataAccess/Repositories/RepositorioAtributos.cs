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
            update = "update TB_CATEGORIA set  Categoria=@Categoria where IdCategoria=@IdCategoria";
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
                    Categoria = item[1].ToString(),
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
    public class RepositorioMarca : RepositorioMaestro, IRepositorioMarca
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioMarca()
        {
            selectAll = "select * from TB_MARCA";
            insert = "insert into TB_MARCA values( @marca)";
            update = "update TB_MARCA set  Marca=@Marca where IdMarca=@IdMarca";
            delete = "delete from TB_MARCA WHERE IdMarca=@IdMarca";
        }
        //este metodo recive como parametro un metodo que es la entidad TB_PRODUCTO
        public int Add(TB_MARCA entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Marca", entity.Marca));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Edit(TB_MARCA entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdMarca", entity.IdMarca));
            parameters.Add(new SqlParameter("@Marca", entity.Marca));

            return ExecuteNonQuery(update);
        }

        public IEnumerable<TB_MARCA> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listProducto = new List<TB_MARCA>();

            foreach (DataRow item in tableResult.Rows)
            {
                listProducto.Add(new TB_MARCA
                {
                    IdMarca = Convert.ToInt32(item[0]),
                    Marca = item[1].ToString(),
                });
            }
            return listProducto;
        }
        public int Remove(int IdMarca)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdMarca", IdMarca));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
    public class RepositorioModelo : RepositorioMaestro, IRepositorioModelo
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        public RepositorioModelo()
        {
            selectAll = "SELECT * FROM TB_MODELO";
            insert = "insert into TB_MODELO values(@IdMarca, @Modelo)";
            update = "update TB_MODELO set  IdMarca=@IdMarca,Modelo=@Modelo where IdModelo=@IdModelo";
            delete = "delete from TB_MODELO WHERE IdModelo=@IdModelo";
        }
        //este metodo recive como parametro un metodo que es la entidad TB_PRODUCTO
        public int Add(TB_MODELO entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdMarca", entity.IdMarca));
            parameters.Add(new SqlParameter("@Modelo", entity.Modelo));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Edit(TB_MODELO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdModelo", entity.IdModelo));
            parameters.Add(new SqlParameter("@IdMarca", entity.IdMarca));
            parameters.Add(new SqlParameter("@Modelo", entity.Modelo));

            return ExecuteNonQuery(update);
        }

        public IEnumerable<TB_MODELO> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listModelo = new List<TB_MODELO>();

            foreach (DataRow item in tableResult.Rows)
            {
                listModelo.Add(new TB_MODELO
                {
                    IdModelo = Convert.ToInt32(item[0]),
                    IdMarca = Convert.ToInt32(item[1]),
                    Marca = item[1].ToString(),
                    Modelo = item[2].ToString(),
                });
            }
            return listModelo;
        }
        public int Remove(int IdModelo)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdModelo", IdModelo));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
}
