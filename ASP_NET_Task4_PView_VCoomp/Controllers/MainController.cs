using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Task4_PView_VCoomp.Controllers;

public class MainController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}