using Mondy.BusinessLogic.Service;
using Mondy.Controllers;
using Mondy.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Mondy.Web
{
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			var prodService = new ProductService();
			var prod = prodService.Take(3);
			if (!prod.Success)
				return HttpNoPermission();

			var view = new HomePageView { RecentlyAdded = prod.Entry };
			return View(view);
		}
	}
}