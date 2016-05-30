using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Chama.Core;
using Chama.Models;
using Chama.Web;

namespace Chama.Controllers
{
    [MvcMenuFilter(false)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var loginer = FormsAuth.GetUserData<LoginerBase>();
            ViewBag.Title = "水务设备管理系统";
            ViewBag.UserName = loginer.UserName;
            ViewBag.Settings = new sys_userService().GetCurrentUserSettings();

            return View();
        }
 
        public ActionResult Error() 
        {
            return View();
        }

        public void Download()
        {
            Exporter.Instance().Download();
        }
    }
}
