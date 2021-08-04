using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public abstract class RepositorioMaestro : Repositorio
    {
        //lista generica de parametros Sql
        protected List<SqlParameter> parameters;

        //metodo de ejecutar comandos de no consulta, 
        //comando para insertar, editar y eliminar datos. 
        protected int ExecuteNonQuery(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        //se encarga de ejecutar comando de consultar leer tablas etc.
        protected DataTable ExecuteReader(string transactSql)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSql;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }
    }

}
