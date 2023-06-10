using Mondy.BusinessLogic.Service;
using Mondy.Domain.Entities;
using Mondy.Filters;
using System.Web.Mvc;

namespace Mondy.Controllers
{
    public class AdminController : BaseController
    {
        [RequireUserRole(UserRole.Admin)]
        public ActionResult Index()
        {
            return View();
        }

        #region Products
        [RequireUserRole(UserRole.Admin)]
        public ActionResult Products()
        {
            var prodService = new ProductService();
            var prodResp = prodService.GetAll();
            if (!prodResp.Success)
                return HttpNoPermission();

            var prod = prodResp.Entry;
            return View(prod);
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditProduct(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var prodService = new ProductService();
            var prodResp = prodService.GetById(id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var prod = prodResp.Entry;
            if (prod == null)
                return HttpNotFound();

            return View(prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var editResp = prodService.Edit(product);
                if (!editResp.Success)
                    return HttpNoPermission();
            }

            return View(product);
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult DeleteProduct(int? id)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteProduct")]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult DeleteProductConfirm(int? id)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var prodResp = prodService.GetById(id.Value);
                if (!prodResp.Success)
                    return HttpNoPermission();

                var product = prodResp.Entry;
                var deleteResp = prodService.Delete(product);
                if (!deleteResp.Success)
                    return HttpNoPermission();
            }

            return RedirectToAction("Products");
        }


        [RequireUserRole(UserRole.Admin)]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var prodService = new ProductService();
                var editResp = prodService.Create(product);
                if (!editResp.Success)
                    return HttpNoPermission();
            }

            return View(product);
        }
        #endregion

        #region Users
        [RequireUserRole(UserRole.Admin)]
        public ActionResult Users()
        {
            var prodService = new UserService();
            var prodResp = prodService.GetAll();
            if (!prodResp.Success)
                return HttpNoPermission();

            var prod = prodResp.Entry;
            return View(prod);
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditUser(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var prodService = new UserService();
            var prodResp = prodService.GetById(id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var prod = prodResp.Entry;
            if (prod == null)
                return HttpNotFound();

            return View(prod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                var prodService = new UserService();
                var editResp = prodService.Edit(user);
                if (!editResp.Success)
                    return HttpNoPermission();
            }

            return View(user);
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult DeleteUser(int? id)
        {
            if (id == null)
                return HttpNotFound();

            var prodService = new UserService();
            var prodResp = prodService.GetById(id.Value);
            if (!prodResp.Success)
                return HttpNoPermission();

            var wine = prodResp.Entry;
            if (wine == null)
                return HttpNotFound();

            return View(wine);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteUser")]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult DeleteUserConfirm(int? id)
        {
            if (ModelState.IsValid)
            {
                var prodService = new UserService();
                var prodResp = prodService.GetById(id.Value);
                if (!prodResp.Success)
                    return HttpNoPermission();

                var product = prodResp.Entry;
                var deleteResp = prodService.Delete(product);
                if (!deleteResp.Success)
                    return HttpNoPermission();
            }

            return RedirectToAction("Users");
        }
        #endregion
    }
}