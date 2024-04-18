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
    public class CountryConfig : BaseEntityConfig<Country>, IEntityTypeConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            base.Configure(builder);
        }
    }
}
