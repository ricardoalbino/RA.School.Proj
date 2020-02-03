using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RA.School.Proj.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RA.School.Proj.Infra.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(keyExpression: p => p.Id);
            builder.Property(p =>  p.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.CPF)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(p => p.Email)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(p => p.Telefone)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(p => p.Sexo)
               .IsRequired()
               .HasColumnType("varchar(50)");

            builder.Property(p => p.DataNascimento)
               .IsRequired()
               .HasColumnType("DataTime");

            /*RELACIONAMENTO*/

            //builder.HasOne(navigationExpression: a => a.UsuarioId)
            //    .WithOne(navigationExpression: u => u.)

            builder.ToTable("Alunos");
        }
    }
}
