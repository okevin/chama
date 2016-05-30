using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chama.Web;

namespace Chama.Areas.Pms.Controllers
{
    [MvcMenuFilter(false)]
    public class HomeController : Controller
    {
        //
        // GET: /Pms/Home/
        //[System.Web.Mvc.AllowAnonymous]
        public ActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
                return Redirect("~/Login/pms");
            return View();
        }

    }
}
