using NetCoreSaaS.Model;

namespace NetCoreSaaS.Data.Entities.Tenant.CompanySetup
{
    public class CategoryDetails : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int ParentCategoryID { get; set; }
    }
}
