using Microsoft.AspNetCore.Mvc;
using MyPortfolio.MyPortfolio.DAL.Context;

namespace MyPortfolio.MyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
