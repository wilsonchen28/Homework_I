using Homework_I.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Homework_I.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Login(LogonViewModel pageData)
        {
            if (pageData.Account == "wilson.chen@iisigroup.com" &&
            pageData.Password == "123456")
            {
                //pageData.ReturnCode = 0;
                pageData.Message =
                $"您使用{pageData.Account}登入成功。";
                TempData["LoginMsg"] = $"您使用{pageData.Account}登入成功。";
                Session.RemoveAll();
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                  pageData.Account,
                  DateTime.Now,
                  DateTime.Now.AddMinutes(1),
                  false,
                  pageData.Account,
                  FormsAuthentication.FormsCookiePath);

                string encTicket = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //pageData.ReturnCode = -1;
                pageData.Message = "登入失敗！";
            }
            return View(pageData);
        }
    }
}