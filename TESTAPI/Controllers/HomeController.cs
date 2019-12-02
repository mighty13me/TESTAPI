using System.Web.Mvc;

namespace TESTAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page changes";

			return View();
		}
	}
}
