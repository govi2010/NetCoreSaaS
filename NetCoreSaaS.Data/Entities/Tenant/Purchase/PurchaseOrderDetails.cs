namespace NetCoreSaaS.Data.Entities.Tenant.Purchase
{
    public class PurchaseOrderDetails
    {
        public int ID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public decimal Cost { get; set; }
    }
}
