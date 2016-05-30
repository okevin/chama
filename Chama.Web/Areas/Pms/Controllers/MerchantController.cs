using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Chama.Core;
using Chama.Models;
using Chama.Web;

namespace Chama.Areas.Pms.Controllers
{
    public class MerchantController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                dataSource = new
                {
                    ProvLvs = new sys_codeService().GetDynamicList(ParamQuery.Instance().Select("Code as value,Text as text").AndWhere("CodeType", "ProvLv"))
                },
                urls = new
                {
                    query = "/api/pms/merchant",
                    //newkey = "/api/pms/product/getnewkey",
                    //edit = "/api/pms/product/edit"
                },
                resx = new
                {
                    noneSelect = "请先选择一条产品数据！",
                    editSuccess = "保存成功！",
                    auditSuccess = "单据已审核！"
                },
                form = new
                {
                    MerchantsCode = "",
                    MerchantsName = "",
                    ContactAddr = ""
                },
                defaultRow = new
                {

                },
                setting = new
                {
                    postListFields = new string[] { "ID", "ProductName", "Color", "Price", "Unit", "Money", "Qty", "Remark", "CreateDate" }
                }
            };
            return View(model);
        }
    }
    public class MerchantApiController : ApiController
    {
        /// <summary>
        /// 地址：GET api/pms/merchant/getnames
        /// 功能：取得收料单供应商
        /// 调用：供应商自动完成
        /// </summary>
        public List<dynamic> GetNames(string q)
        {
            var ReceiveService = new pms_merchantsService();
            var pQuery = ParamQuery.Instance().Select("top 10 MerchantsName").AndWhere("MerchantsName", q, Cp.StartWithPY);
            return ReceiveService.GetDynamicList(pQuery);
        }

        public dynamic GetTypes(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
<settings defaultOrderBy='MerchantsTypeCode'>
   <where defaultIgnoreEmpty='true'>
        <field name='MerchantsTypeCode'      cp='equal'></field>
        <field name='MerchantsTypeName'  cp='like' ></field>
    </where>
</settings>
");
            var result = new pms_merchantsTypeService().GetDynamicListWithPaging(request.ToParamQuery());
            return result;
        }

        public dynamic Get(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
<settings defaultOrderBy='MerchantsCode'>
   <where>
        <field name='MerchantsTypeCode' cp='equal' ignoreEmpty='true'></field>
        <field name='MerchantsName'     cp='like'></field>
    </where>
</settings>");
            var service = new pms_merchantsService();
            var result = service.GetModelListWithPaging(request.ToParamQuery());
            return result;
        }

        public string GetNewCode(string id)
        {
            var service = new pms_merchantsService();
            return service.GetNewKey("MerchantsCode", "maxplus").PadLeft(3, '0');
        }


        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>pms_merchants</table>
    <where>
        <field name='MerchantsCode' cp='equal'></field>
    </where>
</settings>");
            var service = new pms_merchantsService();
            var result = service.Edit(null, listWrapper, data);
        }

        [System.Web.Http.HttpPost]
        public void EditType(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
<settings>
    <table>pms_merchantsType</table>
    <where>
        <field name='MerchantsTypeCode' cp='equal'></field>
    </where>
</settings>");
            var service = new pms_merchantsService();
            var result = service.Edit(null, listWrapper, data);
        }
        /// <summary>
        /// 获得供应商级别列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public dynamic GetProvLv(RequestWrapper request)
        {
            request.LoadSettingXmlString(@"
<settings defaultOrderBy='Code'>
   <where>
        <field name='CodeType' cp='equal' ignoreEmpty='true'></field>
    </where>
</settings>");
            var service = new sys_codeService();
            var result = service.GetModelList(request.ToParamQuery());
            return result;
        }
    }
}
