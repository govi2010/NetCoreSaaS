using NetCoreSaaS.Model;

namespace NetCoreSaaS.Data.Entities.Tenant.ChartOfAccount
{
    public class AccountGroup:BaseEntity
    {
        public int ParentGroupID { get; set; }
        public string AccountGroupName { get; set; }
        public string AccountGroupType { get; set; }
        public string Description { get; set; }
    }
}
