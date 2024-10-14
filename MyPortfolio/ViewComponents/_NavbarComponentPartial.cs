using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.MyPortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
