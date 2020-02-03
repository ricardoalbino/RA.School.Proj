using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.School.Proj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(keyExpression: u => u.Id);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Usuarios");
        }
    }
}
