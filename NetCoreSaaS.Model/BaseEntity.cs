using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreSaaS.Model
{

    public class BaseEntity
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
