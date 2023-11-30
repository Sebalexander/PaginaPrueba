using Microsoft.AspNetCore.Mvc;

public class PortfolioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Detalle(int id)
    {
        return View();
    }
}