using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chama.Web;

namespace Chama.Areas.Dms.Controllers
{
    [MvcMenuFilter(false)]
    public class HomeController : Controller
    {
        //
        // GET: /Dms/Home/
        //[System.Web.Mvc.AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

    }
}
