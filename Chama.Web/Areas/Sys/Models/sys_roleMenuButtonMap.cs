using System;
using System.Collections.Generic;
using System.Text;
using Chama.Core;

namespace Chama.Models
{
    public class sys_roleMenuButtonMapService : ServiceBase<sys_roleMenuButtonMap>
    {
       
    }

    public class sys_roleMenuButtonMap : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int ID{ get; set; }
        public string RoleCode{ get; set; }
        public string MenuCode{ get; set; }
        public string ButtonCode{ get; set; }
    }
}
