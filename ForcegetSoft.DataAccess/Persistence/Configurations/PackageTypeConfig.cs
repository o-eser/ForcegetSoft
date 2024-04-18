using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForcegetSoft.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForcegetSoft.DataAccess.Persistence.Configurations
{
    public class PackageTypeConfig : BaseEntityConfig<PackageType>, IEntityTypeConfiguration<PackageType>
    {
        public override void Configure(EntityTypeBuilder<PackageType> builder)
        {

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(p => p.Offers)
                .WithOne(o => o.PackageType)
                .HasForeignKey(o => o.PackageTypeId);

            base.Configure(builder);
        }
    }
}
