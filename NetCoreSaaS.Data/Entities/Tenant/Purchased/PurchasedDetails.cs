namespace NetCoreSaaS.Data.Entities.Tenant.Purchased
{
    public class PurchasedDetails
    {
        public int PurchasedDetailsID { get; set; }
        public int PurchasedID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }

        public decimal Cost { get; set; }
    }
}
