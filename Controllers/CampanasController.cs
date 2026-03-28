using Microsoft.AspNetCore.Mvc;
using Pc_01.Data;
using Pc_01.Models;
using System.Linq;

namespace Pc_01.Controllers
{
    public class CampanasController : Controller
    {
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
    }
}