using Mondy.BusinessLogic.Service;
using Mondy.Controllers;
using Mondy.Domain.Entities;
using System.Web.Mvc;

namespace Mondy.Web.Controllers
{
    public class ProductController : BaseController
    {
        public ActionResult All()
        {
            var prodService = new ProductService();
            var prodResp = prodService.GetAll();
            if (!prodResp.Success)
                return HttpNoPermission();

            var wine = prodResp.Entry;
            if (wine == null)
                return HttpNotFound();

            return View("list", wine);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var prodService = new ProductService();
            var prodResp = prodService.GetById(id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var wine = prodResp.Entry;
            if (wine == null)
                return HttpNotFound();

            return View(wine);
        }

        public ActionResult Collection(string id)
		{
			var prodService = new ProductService();
			var prodResp = prodService.Get(x => x.Category == id);
			if (!prodResp.Success)
				return HttpNoPermission();

			var prod = prodResp.Entry;
			return View("list", prod);
		}
    }
}
