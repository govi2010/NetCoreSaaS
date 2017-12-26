using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.Item
{
    public class ServiceItem : Item
    {
        #region int
        public int DefaultQty { get; set; }
        public int IncomeAccountID { get; set; }
        public int PurchaseAccountID { get; set; }
        #endregion

        #region decimal
        public decimal Fess { get; set; }
        public decimal ExtraFees { get; set; }
        public decimal Deposit { get; set; }
        #endregion

        public bool IsTaxable { get; set; }
    }
}
