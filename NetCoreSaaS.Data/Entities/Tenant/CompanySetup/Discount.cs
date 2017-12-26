using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public int SaleDetailsID { get; set; }
        public int RepairDetailsID { get; set; }
        public int LessonDetailsID { get; set; }
        public int PurchaseDetailsID { get; set; }

        public decimal DiscountAmount { get; set; }
    }
}
