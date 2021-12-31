using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPORTACIONES MIAS
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    //Genera la interfaz para proveedor extendiendo de la interfaz generica 
    //que muetra 4 funciones que debe cumplir al usar esta interfaz
    public interface IRepositorioProveedor: IGenericRepository<TB_PROVEEDOR>
    {

    }
}
