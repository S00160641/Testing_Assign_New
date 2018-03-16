using System.Web.Mvc;
using TestingAssignmentFit;
using TestingAssignment;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult InputForm(int age, string gender)
        {
            var test = new Program();
            ViewBag.Message = test.CalcPremium(age, gender);
            return View();
        }
    }
}