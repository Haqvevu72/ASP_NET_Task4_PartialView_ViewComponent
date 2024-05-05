using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Task4_PView_VCoomp.ViewComponents;

public class ProjectsViewComponent: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}