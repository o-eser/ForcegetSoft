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
    public class MovementTypeConfig : BaseEntityConfig<MovementType>, IEntityTypeConfiguration<MovementType>
    {
        public override void Configure(EntityTypeBuilder<MovementType> builder)
        {

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(m => m.Offers)
                .WithOne(o => o.MovementType)
                .HasForeignKey(o => o.MovementTypeId);

            base.Configure(builder);
        }
    }
}
