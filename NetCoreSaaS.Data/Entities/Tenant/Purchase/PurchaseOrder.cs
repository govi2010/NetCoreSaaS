using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Purchase
{
    public class PurchaseOrder:BaseEntity
    {
        public int VendorID { get; set; }
        public int WarehouseID { get; set; }

        public string PurchaseOrderNo { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

        public DateTime DeliveryDate { get; set; }
        public DateTime CancellationDate { get; set; }
    }
}
