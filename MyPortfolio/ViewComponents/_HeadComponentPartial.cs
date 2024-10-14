using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.MyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
