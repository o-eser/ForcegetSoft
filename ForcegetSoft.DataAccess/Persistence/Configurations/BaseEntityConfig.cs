using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ForcegetSoft.Core.Entities.Concrete;

namespace ForcegetSoft.DataAccess.Persistence.Configurations
{
    public class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}
