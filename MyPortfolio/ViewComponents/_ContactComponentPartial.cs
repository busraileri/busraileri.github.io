using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
