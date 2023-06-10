using Mondy.BusinessLogic.Service;
using Mondy.Controllers;
using System.Web.Mvc;

namespace Mondy.Web.Controllers
{
	public class AboutController : BaseController
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
