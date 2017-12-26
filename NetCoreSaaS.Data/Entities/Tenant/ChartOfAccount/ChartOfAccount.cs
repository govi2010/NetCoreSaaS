using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.ChartOfAccount
{
    public class ChartOfAccount : BaseEntity
    {
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public int AccountGroupID { get; set; }
    }
}
