using System.Web.Http;
using System.Web.Mvc;
using Chama.Core;
using Chama.Models;
using Chama.Web;

namespace Chama.Areas.Pms.Controllers
{
    [MvcMenuFilter(false)]
    public class MaterialController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class MaterialApiController : ApiController
    {
        public dynamic GetTypes(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
<settings defaultOrderBy='MaterialType'>
   <where defaultIgnoreEmpty='true'>
        <field name='MaterialType'      cp='equal'></field>
        <field name='MaterialsTypeName'  cp='like' ></field>
    </where>
</settings>
");
            var result = new pms_materialTypeService().GetDynamicList(request.ToParamQuery());
            return result;
        }

        public dynamic Get(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
<settings defaultOrderBy='MaterialCode'>
   <where>
        <field name='MaterialType' cp='equal' ignoreEmpty='true'></field>
    </where>
</settings>");
            var service = new pms_materialService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode(string id)
        {
            var service = new pms_materialService();
            return service.GetNewMaterialCode(id);
        }


        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>pms_material</table>
    <where>
        <field name='MaterialCode' cp='equal'></field>
    </where>
</settings>");
            var service = new pms_materialService();
            var result = service.Edit(null, listWrapper, data);
        }

        [System.Web.Http.HttpPost]
        public void EditType(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>pms_materialType</table>
    <where>
        <field name='MaterialType' cp='equal'></field>
    </where>
</settings>");
            var service = new pms_materialService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}
