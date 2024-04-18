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
    public class ModeConfig : BaseEntityConfig<Mode>, IEntityTypeConfiguration<Mode>
    {
        public override void Configure(EntityTypeBuilder<Mode> builder)
        {

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(m => m.Offers)
                .WithOne(o => o.Mode)
                .HasForeignKey(o => o.ModeId);

            base.Configure(builder);
        }
    }
}
