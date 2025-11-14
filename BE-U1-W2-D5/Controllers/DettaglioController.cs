using BE_U1_W2_D5.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BE_U1_W2_D5.Controllers
{
    public class DettaglioController : Controller
    {

        [HttpGet("{id:guid}")]
        public IActionResult Dettaglio(Guid id)
        {

            //var Dettaglio = List.Find(id);
            return View(id);
        }
    }
}
