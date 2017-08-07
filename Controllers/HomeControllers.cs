using Microsoft.AspNetCore.Mvc;
using Address.Models;

namespace LetterVariables.Models
{
    public class HomeController : Controller
{
  [Produces("text/html")]
  [Route("/favorite_photos")]
  [Route("/form")]
    public ActionResult Form()
      {
        return View();
      }
  [Produces("text/html")]
  [Route("/greeting_card")]
  public ActionResult GreetingCard()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient(Request.Query["recipient"]);
          myLetterVariable.SetSender(Request.Query["sender"]);
          return View("Hello", myLetterVariable);
        }
    }

}
