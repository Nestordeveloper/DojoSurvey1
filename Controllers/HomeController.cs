using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View("Index");
    }
    [HttpPost]
    [Route("result")]
    public IActionResult ProcessForm(DojoSurvey model)
    {
        return View("Result", model);
    }
}