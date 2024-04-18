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
    public class Unit1Config : BaseEntityConfig<Unit1>, IEntityTypeConfiguration<Unit1>
    {
        public override void Configure(EntityTypeBuilder<Unit1> builder)
        {

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(u => u.Offers)
                .WithOne(o => o.Unit1)
                .HasForeignKey(o => o.Unit1Id);

            base.Configure(builder);
        }
    }
}
