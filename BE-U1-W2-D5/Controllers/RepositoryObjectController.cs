using BE_U1_W2_D5.Models;
using Microsoft.AspNetCore.Mvc;

namespace BE_U1_W2_D5.Controllers
{
    public class RepositoryObjectController : Controller
    {
        public IActionResult Index()
        {
            var listaScarpe = RepositoryObject.GetAll();
            return View(listaScarpe);
        }
        public IActionResult Dettaglio(string id)
        {
            return RedirectToAction("Dettaglio", new { id = id });
        }
    }
}
