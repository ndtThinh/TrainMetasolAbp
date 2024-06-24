using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TrainMetasolAbp.ProductCategories
{
    public class ProductCategory: CreationAuditedAggregateRoot<Guid>
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String Slug { get; set; }
        public int SortOrder { get; set; }
        public String CoverPicture { get; set; }
        public bool Visilibity { get; set; }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public String SeoMetaDescription  { get; set; }

    }
}
