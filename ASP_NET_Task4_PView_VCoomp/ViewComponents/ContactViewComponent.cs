using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Task4_PView_VCoomp.ViewComponents;

public class ContactViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}