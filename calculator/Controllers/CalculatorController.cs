using calculator.ViewModel;
using System.Web.Mvc;

namespace calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            var vmodel = new CalculatorViewModel();
            return View(vmodel);
        }
    }
}