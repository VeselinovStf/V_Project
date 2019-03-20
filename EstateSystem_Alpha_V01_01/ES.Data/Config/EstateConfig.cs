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
            
        }
    }
}
