using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.Customer
{
    public class Customer:BaseEntity
    {
        #region string
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; } 
        #endregion

        #region int
        public int AccountID { get; set; }
        public int CustomerCategoryID { get; set; }
        public int CityID { get; set; } 
        #endregion
    }
}
