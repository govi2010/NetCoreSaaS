using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup
{
    public class City:BaseEntity
    {
        public string CityName { get; set; }
        public string Zipcode { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
