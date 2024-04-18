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
    public class IncotermConfig : BaseEntityConfig<Incoterm>, IEntityTypeConfiguration<Incoterm>
    {
        public override void Configure(EntityTypeBuilder<Incoterm> builder)
        {

            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(i => i.Offers)
                .WithOne(o => o.Incoterm)
                .HasForeignKey(o => o.IncotermId);

            base.Configure(builder);
        }
    }
}
