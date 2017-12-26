namespace NetCoreSaaS.Data.Entities.Tenant.POS.Sale
{
    public class SaleDetails
    {
        public int SaleDetailsID { get; set; }
        public int SaleID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string SaleItemNote { get; set; }
    }
}
