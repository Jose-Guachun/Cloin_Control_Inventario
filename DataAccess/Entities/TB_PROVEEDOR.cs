using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class TB_PROVEEDOR
    {
        public int IdProveedor { get; set; }
        public int IdTipoDoc { get; set; }
        public string Nombre{ get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
        public string Pais { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NombreOperador { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Descripcion { get; set; }


    }
}
