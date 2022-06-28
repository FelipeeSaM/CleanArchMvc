using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.HasKey(i => i.Id);
            builder.Property(n => n.Name).HasMaxLength(100).IsRequired();
            builder.Property(o => o.Description).HasMaxLength(200).IsRequired(); //IsRequired = não nullable
            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.HasOne(q => q.Category).WithMany(r => r.Products).HasForeignKey(s => s.CategoryId); //relacionamento 1 categoria tem muitos produtos, e categoryId é foreingkey
        }
    }
}
