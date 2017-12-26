using NetCoreSaaS.Model;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.Tax
{
    public class TaxTransaction:BaseEntity
    {
        public int TaxID { get; set; }
        public int SaleDetailsID { get; set; }
        public int RepairDetailsID { get; set; }
        public int LessonDetailsID { get; set; }
        public int PurchasedDetailsID { get; set; }

        public decimal Amount { get; set; }
    }
}
