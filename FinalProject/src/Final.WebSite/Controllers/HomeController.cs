using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Business;
using Final.WebSite.Models;

namespace Final.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassManager classManager;
        private readonly ISchoolManager schoolManager;
        private readonly IUserManager userManager;
        public HomeController(IClassManager classManager, ISchoolManager schoolManager, IUserManager userManager)
        {
            this.classManager = classManager;
            this.schoolManager = schoolManager;
            this.userManager = userManager;
        }

        public ActionResult Class(int id)
        {
            var classes = classManager.Class(id);
            var users = schoolManager
                                .ForClass(id)
                                .Select(t =>
                                    new Final.WebSite.Models.SchoolModel
                                    {
                                        Id = t.Id,
                                        Name = t.Name,
                                        
                                    }).ToArray();

            var model = new ClassViewModel
            {
                Class = new Final.WebSite.Models.ClassModel(classes.Id, classes.Name),
                Users = users
            };

            return View(model);
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginModel loginModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.LogIn(loginModel.UserName, loginModel.Password);

                if (user == null)
                {
                    ModelState.AddModelError("", "User name and password do not match.");
                }
                else
                {
                    Session["User"] = new Final.WebSite.Models.UserModel { Id = user.Id, Name = user.Name };

                    System.Web.Security.FormsAuthentication.SetAuthCookie(loginModel.UserName, false);

                    return Redirect(returnUrl ?? "~/");
                }
            }

            return View(loginModel);
        }

        public ActionResult LogOff()
        {
            Session["User"] = null;
            System.Web.Security.FormsAuthentication.SignOut();

            return Redirect("~/");
        }

        public ActionResult Index()
        {
            var classes = classManager.Classes
                                            .Select(t => new Final.WebSite.Models.ClassModel(t.Id, t.Name))
                                            .ToArray();
            var model = new IndexModel { Classes = classes };
            return View(model);
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
    }
}