using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess.Repositories
{
    public abstract class Repositorio
    //no puede ser instanciada solo se puede heredar
    {
        //readonly es una forma de encapsulacion
        private readonly string connectionString;
        /// <summary>
        /// Antes de escribir esta linea se debe referenciar 
        /// el DataAcces con System.configuration y a su vez 
        /// implementarlo using System.Configuration;
        /// </summary>
        public Repositorio()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BD_Cloin_Facturacion"].ToString();
        }
        // Se obtiene la conexion.
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
