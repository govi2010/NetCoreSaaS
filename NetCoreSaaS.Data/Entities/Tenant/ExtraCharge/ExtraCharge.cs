using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.ExtraCharge
{
    public class ExtraCharge
    {
        public int ExtraChargeID { get; set; }
        public int PurchasedID { get; set; }

        public decimal Amount { get; set; }

        public string Note { get; set; }
    }
}
