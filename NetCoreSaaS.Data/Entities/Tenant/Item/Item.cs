using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Item
{
    public class Item:BaseEntity
    {
        #region string
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; } 
        #endregion

        public byte Picture { get; set; }
    }
}
