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
    public class OfferConfig : BaseEntityConfig<Offer>, IEntityTypeConfiguration<Offer>
    {
        public override void Configure(EntityTypeBuilder<Offer> builder)
        {

            builder.Property(o => o.Unit1Quantity).IsRequired();
            builder.Property(o => o.Unit2Quantity).IsRequired();

            base.Configure(builder);
        }
    }
}
