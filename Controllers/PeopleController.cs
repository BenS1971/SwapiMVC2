using Microsoft.AspNetCore.Mvc;

namespace SwapiMVC2.Controllers;

public class PeopleController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}