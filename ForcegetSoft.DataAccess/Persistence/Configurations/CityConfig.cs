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
    public class CityConfig : BaseEntityConfig<City>, IEntityTypeConfiguration<City>
    {
        public override void Configure(EntityTypeBuilder<City> builder)
        {

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryId);

            builder.HasMany(c => c.Offers)
                .WithOne(o => o.City)
                .HasForeignKey(o => o.CityId);

            base.Configure(builder);
        }
    }
}
