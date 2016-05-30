using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Chama.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();                                   //区域注册

            WebApiConfig.Register(GlobalConfiguration.Configuration);             //WebApi注册
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);            //过滤器注册
            RouteConfig.RegisterRoutes(RouteTable.Routes);                        //路由注册
            BundleConfig.RegisterBundles(BundleTable.Bundles);                    //Bundle注册

            FrameworkConfig.Register();                                           //全局配置
        }
    }
}