using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

[Area("Admin")]
public class DashBoardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}