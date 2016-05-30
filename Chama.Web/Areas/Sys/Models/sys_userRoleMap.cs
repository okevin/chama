using System;
using System.Collections.Generic;
using System.Text;
using Chama.Core;
using System.ComponentModel.DataAnnotations;

namespace Chama.Models
{
    public class sys_userRoleMapService : ServiceBase<sys_userRoleMap>
    {
       
    }
    
    public class sys_userRoleMap : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int ID
        {
            get;
            set;
        }

        public string UserCode
        {
            get;
            set;
        }

        public string RoleCode
        {
            get;
            set;
        }

    }
}