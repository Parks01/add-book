using Microsoft.AspNetCore.Mvc;

namespace Address.Controllers
{
    public class HomeController : Controller
    {
[Produces("text/html")]
[Route("/favorite_photos")]
public string FavoritePhotos()
{
return
"<!DOCTYPE html>" +
"<html>" +
  "<head>" +
    "<title>Hello Friend!</title>" +
    "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
  "</head>" +
  "<body>" +
    "<h1>Favorite Traveling Photos</h1>" +
    "<ul>" +
      "<li><img src='/img/book.jpg'/></li>" +
      "<li><img src='/img/photo2.jpg'/></li>" +
      "<li><img src='/img/photo3.jpg'/></li>" +
    "</ul>" +
  "</body>" +
"</html>";
}
  }
}
