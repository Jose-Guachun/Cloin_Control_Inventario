using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entities
{
    public class TB_CATEGORIA
    {
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
    }
    public class TB_MARCA
    {
        public int IdMarca { get; set; }
        public string Marca { get; set; }
    }
    public class TB_MODELO
    {
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
