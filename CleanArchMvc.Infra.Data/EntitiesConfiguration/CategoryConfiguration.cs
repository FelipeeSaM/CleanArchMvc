using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration {
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.HasKey(p => p.Id);
            builder.Property(n => n.Name).HasMaxLength(100).IsRequired();

            //insere manualmente 3 registros no banco
            builder.HasData(new Category(1, "Casa"),
                new Category(2, "Eletrônicos"),
                new Category(3, "Acessórios")
                );
        }
    }
}
