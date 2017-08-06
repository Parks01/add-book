using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers
{
    public class HomeController : Controller
    {
[Produces("text/html")]
[Route("/")]
public ActionResult Interface()
{
  return View();
}
  }
}
