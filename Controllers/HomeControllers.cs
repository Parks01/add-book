using Microsoft.AspNetCore.Mvc;
using Address.Models;

namespace LetterVariables.Models
{
    public class HomeController : Controller
{

        [HttpGet("/")]
        public ActionResult Form()
        {
          return View("form");
        }
        [HttpPost("/list")]
        public ActionResult List()
        {

          List<Place> allPlaces = Place.GetAll();
          return View(allPlaces);

        }

    }

}
