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
    public class Unit2Config : BaseEntityConfig<Unit2>, IEntityTypeConfiguration<Unit2>
    {
        public override void Configure(EntityTypeBuilder<Unit2> builder)
        {

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(u => u.Offers)
                .WithOne(o => o.Unit2)
                .HasForeignKey(o => o.Unit2Id);

            base.Configure(builder);
        }
    }
}
