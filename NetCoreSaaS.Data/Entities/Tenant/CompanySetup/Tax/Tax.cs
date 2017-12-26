using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.Tax
{
    public class Tax:BaseEntity
    {
        public int ParentID { get; set; }
        public int WarehouseID { get; set; }
        public int AccountID { get; set; }

        public string TaxName { get; set; }
        public string Description { get; set; }

        public bool IsDefaultTax { get; set; }

        public DateTime ApplicableDate { get; set; }
    }
}
