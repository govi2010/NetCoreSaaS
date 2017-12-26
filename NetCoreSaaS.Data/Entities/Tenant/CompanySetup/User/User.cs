using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.User
{
    public class User:BaseEntity
    {
        #region string
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 
        #endregion

        public int UserTypeID { get; set; }
    }
}
