namespace NetCoreSaaS.Data.Entities.Tenant.POS.Repair
{
    public class RepairDetails
    {
        public int RepairDetailsID { get; set; }
        public int RepairID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string RepairItemNote { get; set; }
    }
}
