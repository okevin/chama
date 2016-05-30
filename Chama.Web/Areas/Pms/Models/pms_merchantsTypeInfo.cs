using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chama.Core;

namespace Chama.Models
{
    [Module("Pms")]
    public class pms_merchantsTypeService : ServiceBase<pms_merchantsType>
    {

    }

    public class pms_merchantsType : ModelBase
    {

        [PrimaryKey]
        public string MerchantsTypeCode { get; set; }
        public string MerchantsTypeName { get; set; }
        public string MerchantsProperty { get; set; }
        public string CreatePerson { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdatePerson { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remark { get; set; }
    }
}