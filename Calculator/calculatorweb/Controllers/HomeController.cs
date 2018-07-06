using System.Web.Mvc;
using Calculator.TwoArgument;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace calculatorweb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multyplication", Text ="multyplication"
                },
                new SelectListItem()
                {
                    Value = "addition", Text ="addition"
                },
                new SelectListItem()
                {
                    Value = "sabtraction", Text ="sabtraction"
                },
                new SelectListItem()
                {
                    Value = "division", Text ="division"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstValue, double secondValue, string operation)
        {
            ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator(operation);
            double result = calculator.Calculator(firstValue, secondValue);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "multyplication", Text ="multyplication"
                },
                new SelectListItem()
                {
                    Value = "addition", Text ="addition"
                },
                new SelectListItem()
                {
                    Value = "sabtraction", Text ="sabtraction"
                },
                new SelectListItem()
                {
                    Value = "division", Text ="division"
                }
            };
            return View();
        }
    }
}