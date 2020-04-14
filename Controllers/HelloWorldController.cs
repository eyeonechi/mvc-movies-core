using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovies.Controllers
{
  public class HelloWorldController : Controller
  {
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
      return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int ID = 1, int numTimes = 1)
    {
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = numTimes;
      return View();
    }
  }
}
