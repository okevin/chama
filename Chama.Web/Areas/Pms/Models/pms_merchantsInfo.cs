using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chama.Core;

namespace Chama.Models
{
    [Module("Pms")]
    public class pms_merchantsService : ServiceBase<pms_merchants>
    {

    }

    public class pms_merchants : ModelBase
    {

        [PrimaryKey]
        public string MerchantsCode { get; set; }
        public string MerchantsName { get; set; }
        public string MerchantsTypeCode { get; set; }
        public string MerchantsTypeName { get; set; }
        public string ChargePerson { get; set; }  //法人
        public string ChargeTel { get; set; }     //法人电话
        public string RegisterFund { get; set; }  //注册资金
        public DateTime? BuildDate { get; set; }  //成立日期
        public string BusinessScope { get; set; } //经营范围
        public string BusinessType { get; set; }  //公司类型
        public string QualificationLevel { get; set; }  //公司级别
        public string Bank { get; set; }                //开户行
        public string BankAccount { get; set; }             //银行账号
        public string ContactPerson { get; set; }      //联系人
        public string ContactTel { get; set; }         //联系人电话
        public string ContactPosition { get; set; }    //联系地点
        public string ContactAddr { get; set; }        //联系地址
        public string ContactPostCode { get; set; }    //邮政编码
        public string ContactFax { get; set; }         //传真
        public string Website { get; set; }            //网址
        public string EMail { get; set; }              //电邮
        public string BusinessLicence { get; set; }   //营业执照注册号
        public string OrganizationCodeCertificate { get; set; } //组织机构代码
        public string TaxRegistrationCertificateNo { get; set; } //水务登记号
        public string BusinessLicenceExpDate { get; set; }       //有效期
        public bool GeneralTaxpayer { get; set; }                //是否一般纳税人
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remark { get; set; }
    }
}