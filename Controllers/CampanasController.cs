using Microsoft.AspNetCore.Mvc;
using Pc_01.Data;
using Pc_01.Models;
using System.Linq;

namespace Pc_01.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var campanias = CampaniaData.Campanias;
            return View(campanias);
        }

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