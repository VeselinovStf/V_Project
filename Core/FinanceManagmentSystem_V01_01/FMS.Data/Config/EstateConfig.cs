using FMS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Data.Config
{
    public class EstateConfig : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {
            builder.HasOne(e => e.EstateOwnerUser)
                .WithMany(o => o.Estates)
               .HasForeignKey(e => e.EstateOwnerUser_Id);
        }
    }
}
