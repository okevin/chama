using System.Web.Http;
using System.Web.Mvc;
using Chama.Web;

namespace Chama.Areas.Pms
{
    public class PmsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Pms";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "default",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string[] { "Chama.Areas." + this.AreaName + ".Controllers" } //第四个参数是命名空间参数，表示这个路由设置只在此命名空间下有效
            );

            GlobalConfiguration.Configuration.Routes.MapHttpRoute(
                this.AreaName + "Api",
                "api/" + this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, action = RouteParameter.Optional, id = RouteParameter.Optional, namespaceName = new string[] { string.Format("Chama.Areas.{0}.Controllers", this.AreaName) } },
                new { action = new StartWithConstraint() }
            );
        }
    }
}
