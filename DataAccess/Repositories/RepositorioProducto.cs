using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Importacion
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public class RepositorioProducto : RepositorioMaestro, IRepositorioProducto
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        //constructor
        public RepositorioProducto()
        {
            selectAll = "select * from TB_PRODUCTO ";
            insert = "insert into TB_PRODUCTO values(@IdCompra, @IdMarca, @IdModelo, @IdCategoria, @Codigo, @Cantidad, @Img, @Titulo, @Caracteristicas, @Precio, @Coste, @Margen, @PVP, @IVA, @Descuento, @Total)";
            update = "update TB_PRODUCTO set IdCompra=@IdCompra, IdMarca=@IdMarca, IdModelo=@IdModelo,IdCategoria=@IdCategoria, Codigo=@Codigo, Cantidad=@Cantidad, Img=@Img, Titulo=@Titulo, Caracteristicas=@Caracteristicas, Precio=@Precio, Coste=@Coste, Margen=@Margen, PVP=@PVP, IVA=@IVA, Descuento=@Descuento, Total=@Total  where IdProducto=@IdProducto";
            delete = "delete from TB_PRODUCTO WHERE IdProducto=@IdProducto";
        }
        //este metodo recive como parametro un metodo que es la entidad TB_PRODUCTO
        public int Add(TB_PRODUCTO entity)
        {
            //creamos una lista de parametros referenciar el data
            //y el data.sqlclient.
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdCompra", entity.IdCompra));
            parameters.Add(new SqlParameter("@IdMarca", entity.IdMarca));
            parameters.Add(new SqlParameter("@IdModelo", entity.IdModelo));
            parameters.Add(new SqlParameter("@IdCategoria", entity.IdCategoria));
            parameters.Add(new SqlParameter("@Codigo", entity.Codigo));
            parameters.Add(new SqlParameter("@Cantidad", entity.Cantidad));
            parameters.Add(new SqlParameter("@Img", entity.Img));
            parameters.Add(new SqlParameter("@Titulo", entity.Titulo));
            parameters.Add(new SqlParameter("@Caracteristicas", entity.Caracteristicas));
            parameters.Add(new SqlParameter("@Precio", entity.Precio));
            parameters.Add(new SqlParameter("@Coste", entity.Coste));
            parameters.Add(new SqlParameter("@Margen", entity.Margen));
            parameters.Add(new SqlParameter("@PVP", entity.PVP));
            parameters.Add(new SqlParameter("@IVA", entity.IVA));
            parameters.Add(new SqlParameter("@Descuento", entity.Descuento));
            parameters.Add(new SqlParameter("@Total", entity.Total));
            //requiere que enviemos un comando transactSQL 
            return ExecuteNonQuery(insert);
        }

        public int Edit(TB_PRODUCTO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdProducto", entity.IdProducto));
            parameters.Add(new SqlParameter("@IdCompra", entity.IdCompra));
            parameters.Add(new SqlParameter("@IdMarca", entity.IdMarca));
            parameters.Add(new SqlParameter("@IdModelo", entity.IdModelo));
            parameters.Add(new SqlParameter("@IdCategoria", entity.IdCategoria));
            parameters.Add(new SqlParameter("@Codigo", entity.Codigo));
            parameters.Add(new SqlParameter("@Cantidad", entity.Cantidad));
            parameters.Add(new SqlParameter("@Img", entity.Img));
            parameters.Add(new SqlParameter("@Titulo", entity.Titulo));
            parameters.Add(new SqlParameter("@Caracteristicas", entity.Caracteristicas));
            parameters.Add(new SqlParameter("@Precio", entity.Precio));
            parameters.Add(new SqlParameter("@Coste", entity.Coste));
            parameters.Add(new SqlParameter("@Margen", entity.Margen));
            parameters.Add(new SqlParameter("@PVP", entity.PVP));
            parameters.Add(new SqlParameter("@IVA", entity.IVA));
            parameters.Add(new SqlParameter("@Descuento", entity.Descuento));
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
                    NumCompra = item[1].ToString(),
                    Marca = item[2].ToString(),
                    Modelo = item[3].ToString(),
                    Categoria = item[4].ToString(),
                    Codigo = item[5].ToString(),
                    Cantidad = Convert.ToInt32(item[6]),
                    Titulo = item[8].ToString(),
                    Caracteristicas = item[9].ToString(),
                    Precio = decimal.Parse(item[10].ToString()),
                    Coste = decimal.Parse(item[11].ToString()),
                    Margen = decimal.Parse(item[12].ToString()),
                    PVP = decimal.Parse(item[13].ToString()),
                    IVA = decimal.Parse(item[14].ToString()),
                    Descuento = decimal.Parse(item[15].ToString()),
                    Total = decimal.Parse(item[16].ToString()),
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
