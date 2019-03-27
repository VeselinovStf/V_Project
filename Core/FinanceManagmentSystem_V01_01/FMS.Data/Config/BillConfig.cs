using FMS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.Data.Config
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasOne(b => b.PersonalUSer)
                .WithMany(e => e.Bills)
                .HasForeignKey(b => b.PersonalUser_Id);
        }
    }
}
