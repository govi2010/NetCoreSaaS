using NetCoreSaaS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Data.Entities.Tenant.POS
{
    public class Ticket:BaseEntity
    {
        #region string
        public string TicketNo { get; set; }
        public string TicketType { get; set; }
        public string TicketNote { get; set; } 
        #endregion

        public int CustomerID { get; set; }
        public int DrawerID { get; set; }
    }
}
