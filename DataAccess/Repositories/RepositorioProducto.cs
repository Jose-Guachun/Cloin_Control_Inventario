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
    // REPOSITORIO PRODUCTO
    public class RepositorioProducto : RepositorioMaestro, IRepositorioProducto
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        //constructor
        public RepositorioProducto()
        {
            selectAll = "select IdProducto,C.IdCategoria,  MA.IdMarca, M.IdModelo, Categoria, Marca, Modelo, Codigo_SKU, Codigo_UPC, Titulo, Cantidad, Caracteristicas, Coste, Margen, Descuento,Utilidad, PVP, IVA, Total from TB_PRODUCTO P, TB_CATEGORIA C, TB_MODELO M, TB_MARCA MA where C.IdCategoria=P.IdCategoria and M.IdModelo=P.IdModelo and MA.IdMarca=M.IdMarca";
            insert = "insert into TB_PRODUCTO values( @IdModelo, @IdCategoria, @Codigo_SKU, @Codigo_UPC, @Titulo, @Cantidad, @Caracteristicas, @Coste, @Margen, @Descuento,@Utilidad, @PVP, @IVA, @Total)";
            update = "update TB_PRODUCTO set  IdModelo=@IdModelo, IdCategoria=@IdCategoria, Codigo_SKU=@Codigo_SKU,Codigo_UPC=@Codigo_UPC, Titulo=@Titulo, Cantidad=@Cantidad, Caracteristicas=@Caracteristicas, Coste=@Coste, Margen=@Margen, Descuento=@Descuento,Utilidad=@Utilidad, PVP=@PVP, IVA=@IVA, Total=@Total  where IdProducto=@IdProducto";
            delete = "delete from TB_PRODUCTO WHERE IdProducto=@IdProducto";
        }

        //este metodo recive como parametro un metodo que es la entidad TB_PRODUCTO
        public int Add(TB_PRODUCTO entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdModelo", entity.IdModelo));
            parameters.Add(new SqlParameter("@IdCategoria", entity.IdCategoria));
            parameters.Add(new SqlParameter("@Codigo_SKU", entity.Codigo_SKU.ToUpper()));
            parameters.Add(new SqlParameter("@Codigo_UPC", entity.Codigo_UPC));
            parameters.Add(new SqlParameter("@Titulo", entity.Titulo.ToUpper()));
            parameters.Add(new SqlParameter("@Cantidad", entity.Cantidad));
            parameters.Add(new SqlParameter("@Caracteristicas", entity.Caracteristicas));
            parameters.Add(new SqlParameter("@Coste", entity.Coste));
            parameters.Add(new SqlParameter("@Margen", entity.Margen));
            parameters.Add(new SqlParameter("@Descuento", entity.Descuento));
            parameters.Add(new SqlParameter("@Utilidad", entity.Utilidad));
            parameters.Add(new SqlParameter("@PVP", entity.PVP));
            parameters.Add(new SqlParameter("@IVA", entity.IVA));
            parameters.Add(new SqlParameter("@Total", entity.Total));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Edit(TB_PRODUCTO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdProducto", entity.IdProducto));
            parameters.Add(new SqlParameter("@IdModelo", entity.IdModelo));
            parameters.Add(new SqlParameter("@IdCategoria", entity.IdCategoria));
            parameters.Add(new SqlParameter("@Codigo_SKU", entity.Codigo_SKU));
            parameters.Add(new SqlParameter("@Codigo_UPC", entity.Codigo_UPC));
            parameters.Add(new SqlParameter("@Titulo", entity.Titulo.ToUpper()));
            parameters.Add(new SqlParameter("@Cantidad", entity.Cantidad));
            parameters.Add(new SqlParameter("@Caracteristicas", entity.Caracteristicas));
            parameters.Add(new SqlParameter("@Coste", entity.Coste));
            parameters.Add(new SqlParameter("@Margen", entity.Margen));
            parameters.Add(new SqlParameter("@Descuento", entity.Descuento));
            parameters.Add(new SqlParameter("@Utilidad", entity.Utilidad));
            parameters.Add(new SqlParameter("@PVP", entity.PVP));
            parameters.Add(new SqlParameter("@IVA", entity.IVA));  
            parameters.Add(new SqlParameter("@Total", entity.Total));
            return ExecuteNonQuery(update);
        }
        
        public IEnumerable<TB_PRODUCTO> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listProducto = new List<TB_PRODUCTO>();
           
            foreach (DataRow item in tableResult.Rows)
            {
                listProducto.Add(new TB_PRODUCTO
                {
                    IdProducto = Convert.ToInt32(item[0]),
                    IdCategoria = Convert.ToInt32(item[1]),
                    IdMarca = Convert.ToInt32(item[2]),
                    IdModelo = Convert.ToInt32(item[3]),
                    Categoria = item[4].ToString(),
                    Marca = item[5].ToString(),
                    Modelo = item[6].ToString(),
                    Codigo_SKU = item[7].ToString(),
                    Codigo_UPC = item[8].ToString(),
                    Titulo = item[9].ToString(),
                    Cantidad = Convert.ToInt32(item[10]),
                    Caracteristicas = item[11].ToString(),
                    Coste = decimal.Parse(item[12].ToString()),
                    Margen = Convert.ToInt32(item[13].ToString()),
                    Descuento = Convert.ToInt32(item[14].ToString()),
                    Utilidad = decimal.Parse(item[15].ToString()),
                    PVP = decimal.Parse(item[16].ToString()),
                    IVA = decimal.Parse(item[17].ToString()),
                    Total = decimal.Parse(item[18].ToString()),
                }) ; 
            }
            return listProducto;
        }
        public int Remove(int IdProducto)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdProducto", IdProducto));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(delete);
        }
    }
}
