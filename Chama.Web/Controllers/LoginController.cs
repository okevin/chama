using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Chama.Core;
using Chama.Models;
using Chama.Utils;
using Chama.Web;
//using Chama.Web.Areas.Mms.Common;

namespace Chama.Controllers
{
    [AllowAnonymous]
    [MvcMenuFilter(false)]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.CnName = "企业管理系统";
            //ViewBag.EnName = "Enterprise Mangange System";
            //return View();
            return Dms();
        }

        public ActionResult Pms()
        {
            ViewBag.CnName = "水务采购管理系统";
            ViewBag.EnName = "Purchase Management System";
            return View("Index");
        }

        public ActionResult Dms()
        {
            ViewBag.CnName = "水务设备管理系统";
            ViewBag.EnName = "Device Management System";
            return View("Index");
        }

        public ActionResult Psi() 
        {
            ViewBag.CnName = "企业进销存管理系统";
            ViewBag.EnName = "Purchase-Sales-Inventory Management System";
            ViewBag.EnNameStyle = "left:298px;";
            return View("Index");
        }



        public JsonResult DoAction(JObject request)
        {
            var message = new sys_userService().Login(request);
            return Json(message, JsonRequestBehavior.DenyGet);
        }

        public ActionResult Logout()
        {
            FormsAuth.SingOut();
            return Redirect("~/Login");
        }
    }
}
