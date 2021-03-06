﻿using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Vendor
{
    public class Vendor:BaseEntity
    {
        #region string
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string CityID { get; set; } 
        #endregion

        public int AccountID { get; set; }
    }
}
