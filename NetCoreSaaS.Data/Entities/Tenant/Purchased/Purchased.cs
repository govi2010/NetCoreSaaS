using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Purchased
{
    public class Purchased:BaseEntity
    {
        public int PurchaseOrederID { get; set; }

        public string PurchasedNo { get; set; }
        public string Note { get; set; }

        public DateTime PurchasedDate { get; set; }
        public DateTime InvoiceDate { get; set; }

        public decimal Freight { get; set; }
    }
}
