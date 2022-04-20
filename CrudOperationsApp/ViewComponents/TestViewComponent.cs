using Microsoft.AspNetCore.Mvc;

namespace CrudOperationsApp.ViewComponents
{
    public class TestViewComponent:ViewComponent 
    {
        public TestViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
