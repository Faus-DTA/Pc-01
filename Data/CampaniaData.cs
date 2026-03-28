using System;
using System.Collections.Generic;
using Pc_01.Models;

namespace Pc_01.Data
{
    public class CampaniaData
    {
        public static List<Campania> Campanias = new List<Campania>
        {
            new Campania { Id = 1, Nombre = "Cierra Puertas Deco", Categoria = "Hogar", Estado = "Vigente", FechaInicio = new DateTime(2023, 1, 1), FechaFin = new DateTime(2023, 12, 31), DescuentoPct = 15, Canal = "Web", Descripcion = "Descuentos en decoración de hogar" },
            new Campania { Id = 2, Nombre = "Cyber Wow Tech", Categoria = "Tecnología", Estado = "Próxima", FechaInicio = new DateTime(2023, 6, 1), FechaFin = new DateTime(2023, 6, 30), DescuentoPct = 25, Canal = "App", Descripcion = "Ofertas en gadgets tecnológicos" },
            new Campania { Id = 3, Nombre = "Moda Primavera", Categoria = "Moda", Estado = "Finalizada", FechaInicio = new DateTime(2023, 3, 1), FechaFin = new DateTime(2023, 3, 31), DescuentoPct = 30, Canal = "Tienda", Descripcion = "Colección primavera con descuentos" },
            new Campania { Id = 4, Nombre = "Electro Hogar Plus", Categoria = "Electro", Estado = "Vigente", FechaInicio = new DateTime(2023, 5, 1), FechaFin = new DateTime(2023, 11, 30), DescuentoPct = 20, Canal = "Web", Descripcion = "Electrodomésticos para el hogar" },
            new Campania { Id = 5, Nombre = "Tech Weekend", Categoria = "Tecnología", Estado = "Próxima", FechaInicio = new DateTime(2023, 7, 1), FechaFin = new DateTime(2023, 7, 7), DescuentoPct = 10, Canal = "App", Descripcion = "Descuentos especiales fin de semana en tecnología" }
        };
    }
}