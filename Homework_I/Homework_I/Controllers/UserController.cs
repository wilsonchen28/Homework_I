using Homework_I.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Login(LogonViewModel pageData)
        {
            //if (pageData.Account == "skill" &&
            //pageData.Password == "tree")
            if (pageData.Account == "skill@gmail.com" &&
            pageData.Password == "tree")
            {
                pageData.Message =
                $"您使用{pageData.Account}登入成功。";
            }
            return View(pageData);
        }
    }
}