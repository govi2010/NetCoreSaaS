using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.Unit
{
    class Unit:BaseEntity
    {
        public string UnitName { get; set; }
        public int ParentUnitID { get; set; }
        public decimal UnitValue { get; set; }
        public bool IsDefault { get; set; }
    }
}
