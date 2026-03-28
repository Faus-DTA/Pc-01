using Microsoft.AspNetCore.Mvc;
using Pc_01.Data;
using Pc_01.Models;

namespace Pc_01.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var campanias = CampaniaData.Campanias;
            return View(campanias);
        }
    }
}