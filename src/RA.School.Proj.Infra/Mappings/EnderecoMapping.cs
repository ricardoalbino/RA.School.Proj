using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.School.Proj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Infra.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        
       

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Lagradouro)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(e => e.Numero)
              .IsRequired()
              .HasColumnType("varchar(12)");

            builder.Property(e => e.Complemento)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.Property(e => e.CEP)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.Property(e => e.Bairro)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.Property(e => e.Cidade)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.Property(e => e.Estado)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.ToTable("Endereco");
        }
    }
}
