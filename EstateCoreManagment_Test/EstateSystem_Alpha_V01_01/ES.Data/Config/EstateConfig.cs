using ES.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Data.Config
{
    public class EstateConfig : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {
            builder.Property(e => e.City)
                .HasColumnName("City")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Country)
                .HasColumnName("Country")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Street)
                .HasColumnName("Street")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.StreetAddress)
                .HasColumnName("Street Address")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(e => e.Size)
                .HasColumnName("Size")
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(e => e.Description)
                .HasColumnName("Description")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(e => e.IsPublic)
                .HasColumnName("Public")
                .IsRequired();

            builder.Property(e => e.IsRentable)               
                .IsRequired();

            builder.Property(e => e.IsSellable)
                .IsRequired();

            builder.Property(e => e.SellingPrice)
                .HasColumnType("money")               
                .IsRequired();

            builder.Property(e => e.RentingPrice)
                .HasColumnType("money")               
                .IsRequired();

            builder.Property(e => e.Capacity)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(e => e.ImageAddres)
                .IsRequired();
        }
    }
}
