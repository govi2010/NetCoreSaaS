using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.POS.Repair
{
    public class Repair
    {
        public int RepairID { get; set; }
        public int TicketID { get; set; }

        public string RepairStatus { get; set; }
        public string ItemName { get; set; }
        public string SerialNo { get; set; }
    }
}
