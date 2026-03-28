using System;
using System.ComponentModel.DataAnnotations;

namespace Pc_01.Models
{
    public class Campania
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; } // Electro, Hogar, Moda, Tecnología
        public string Estado { get; set; } // Vigente, Próxima, Finalizada
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaInicio { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaFin { get; set; }
        public int DescuentoPct { get; set; }
        public string Canal { get; set; } // Web, App, Tienda
        public string Descripcion { get; set; }
    }
}