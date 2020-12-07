using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DareZameen_Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            return View();
        }
    }
}