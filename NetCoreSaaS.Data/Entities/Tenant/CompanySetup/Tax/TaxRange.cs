namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup.Tax
{
    public class TaxRange
    {
        public int TaxRangeID { get; set; }
        public int TaxID { get; set; }

        public decimal FromAmount { get; set; }
        public decimal ToAmount { get; set; }
        public decimal TaxPercent { get; set; }

        public string Description { get; set; }
        public int CreatedBy { get; set; }
    }
}
