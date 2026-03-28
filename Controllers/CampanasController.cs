using Microsoft.AspNetCore.Mvc;
using Pc_01.Data;
using Pc_01.Models;

namespace Pc_01.Controllers
{
    public class CampanasController : Controller
    {
        // Método Index con Filtros (Funcionalidad 1)
        public IActionResult Index(string categoria, string estado)
        {
            var campanias = CampaniaData.Campanias.AsQueryable();

            if (!string.IsNullOrEmpty(categoria))
            {
                campanias = campanias.Where(c => c.Categoria == categoria);
            }

            if (!string.IsNullOrEmpty(estado))
            {
                campanias = campanias.Where(c => c.Estado == estado);
            }

            return View(campanias.ToList());
        }

        // Método Details (Funcionalidad 2 - ¡Agregado!)
        public IActionResult Details(int id)
        {
            var campania = CampaniaData.Campanias.FirstOrDefault(c => c.Id == id);
            
            if (campania == null)
            {
                return NotFound();
            }
            
            return View(campania);
        }
    }
}