using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Contracts
{
    public interface IRepositorioProducto : IGenericRepository<TB_PRODUCTO>
    {

    }
    public interface IRepositorioCategoria : IGenericRepository<TB_CATEGORIA>
    {

    }
    public interface IRepositorioMarca : IGenericRepository<TB_MARCA>
    {

    }
    public interface IRepositorioModelo : IGenericRepository<TB_MODELO>
    {

    }
}
