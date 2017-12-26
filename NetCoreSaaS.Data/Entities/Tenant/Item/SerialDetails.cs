using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Item
{
    public class SerialDetails:BaseEntity
    {
        public string SerialNo { get; set; }
        public decimal SerialPrice { get; set; }
        public bool HaveSerialPrice { get; set; }
        public string SerialStatus { get; set; } //Sold,Active,Deactive
    }
}
