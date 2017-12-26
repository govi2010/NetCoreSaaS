using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup
{
    public class Manufacturer:BaseEntity
    {
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
}
