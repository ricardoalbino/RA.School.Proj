using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RA.School.Proj.Domain.Models;

namespace RA.School.Proj.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
